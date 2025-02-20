using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    // Editor variables
    [Header("Game behaviour")]
    [SerializeField]
    private int winScore;
    [SerializeField]
    private BallController ball;
    [SerializeField]
    private PaddleController paddleLeft;
    [SerializeField]
    private PaddleController paddleRight;

    [Header("UI Elements")]
    [SerializeField]
    private TextMeshProUGUI leftScoreText;
    [SerializeField]
    private TextMeshProUGUI rightScoreText;

    [Header("Sounds")]
    [SerializeField]
    private AudioClip scoreEffect;

    // Private variables
    private new AudioSource audio;
    private AIController aiController;
    private int leftScore;
    private int rightScore;

    #region Unity methods
    private void Awake() {
        audio = GetComponent<AudioSource>();
        aiController = GetComponent<AIController>();
        leftScore = 0;
        rightScore = 0;
    }

    private void Start() {
        // Initialize paddles
        paddleLeft.EntityController = GameEntity.Player1;
        paddleRight.EntityController = PersistentInformation.Instance == null || PersistentInformation.Instance.PlayMode == PlayMode.SinglePlayer ? GameEntity.AI : GameEntity.Player2;
        paddleLeft.enabled = true;
        paddleRight.enabled = true;
        aiController.enabled = paddleRight.EntityController == GameEntity.AI;

        // Initialize ball
        var startDirection = Random.Range(0f, 1f) > 0.5f ? Vector2.right : Vector2.left;
        ball.ResetBall(GetDirection(startDirection));
    }
    #endregion

    #region Public calls
    public void PaddleLeftScored() {
        leftScore++;
        leftScoreText.SetText($"{leftScore}");
        if (leftScore >= winScore) EndGame(paddleLeft.EntityController);
        else ball.ResetBall(GetDirection(Vector2.right));

        audio.PlayOneShot(scoreEffect);
    }

    public void PaddleRightScored() {
        rightScore++;
        rightScoreText.SetText($"{rightScore}");
        if (rightScore >= winScore) EndGame(paddleRight.EntityController);
        else ball.ResetBall(GetDirection(Vector2.left));

        audio.PlayOneShot(scoreEffect);
    }
    #endregion

    #region Private methods
    private void EndGame(GameEntity winner) {
        PersistentInformation.Instance.GameWinner = winner;
        SceneManager.LoadScene("EndScene");
    }
    #endregion

    #region Auxiliar functions
    private Vector2 GetDirection(Vector2 xDirection) {
        var yDirection = Random.Range(0f, 1f) > 0.5f ? Vector2.up : Vector2.down;
        return (xDirection + yDirection).normalized;
    }
    #endregion
}
