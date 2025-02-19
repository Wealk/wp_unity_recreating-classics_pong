using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PaddleController : MonoBehaviour {
    private const float COURT_SIZE = 4.5f;
    private const float DETECTION_OFFSET = 0.05f;

    // Public properties
    public GameEntity EntityController { get { return entityController; } set { entityController = value; } }

    // Editor variables
    [SerializeField]
    private GameEntity entityController;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float maxAngle;

    // Private variables
    private PongActions actions;
    private new BoxCollider2D collider;
    private BallController ball;
    private Vector2 direction;
    private Vector2 contactPoint;
    private float halfBound;

    #region Unity methods
    private void Awake() {
        actions = new PongActions();
        collider = GetComponent<BoxCollider2D>();
        direction = Vector2.zero;
        contactPoint = Vector2.zero;
        halfBound = (collider.bounds.size.y / 2f) - DETECTION_OFFSET;
    }

    private void Start() {
        switch (entityController) {
            case GameEntity.Player1:
                actions.Game.PaddleLeft.performed += HandlePaddleMovement;
                actions.Game.PaddleLeft.canceled += HandleStopMovement;
                actions.Game.Reset.started += HandleResetGame;
                break;
            case GameEntity.Player2:
                actions.Game.PaddleRight.performed += HandlePaddleMovement;
                actions.Game.PaddleRight.canceled += HandleStopMovement;
                actions.Game.Reset.started += HandleResetGame;
                break;
        }
    }

    private void OnEnable() {
        actions.Game.Enable();
    }

    private void OnDisable() {
        actions.Game.Disable();
    }

    private void FixedUpdate() {
        if (direction != Vector2.zero) {
            transform.position += movementSpeed * Time.fixedDeltaTime * (Vector3)direction;

            if (transform.position.y > COURT_SIZE) transform.position = new Vector3(transform.position.x, COURT_SIZE, 0);
            else if (transform.position.y < -COURT_SIZE) transform.position = new Vector3(transform.position.x, -COURT_SIZE, 0);
        }

        if (contactPoint != Vector2.zero) {

        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Ball") && collision.collider.TryGetComponent(out ball)) {
            var contactPoint = collision.GetContact(0).point;
            var upperBound = transform.position.y + halfBound;
            var lowerBound = transform.position.y - halfBound;
            if (contactPoint.y > lowerBound && contactPoint.y < upperBound) {
                var relativeY = (contactPoint.y - transform.position.y) / (collider.bounds.size.y / 2);
                var bounceRadians = Mathf.Clamp(relativeY, -1f, 1f) * maxAngle * Mathf.Deg2Rad;

                ball.NotifyPaddleCollision(bounceRadians);
            }
        }
    }
    #endregion

    #region Public calls
    public void MoveUp() {
        direction = Vector2.up;
    }

    public void MoveDown() {
        direction = Vector2.down;
    }

    public void StopMovement() {
        direction = Vector2.zero;
    }
    #endregion

    #region Private methods
    private void HandlePaddleMovement(InputAction.CallbackContext context) {
        if (context.ReadValue<float>() > 0) MoveUp();
        else MoveDown();
    }

    private void HandleStopMovement(InputAction.CallbackContext context) {
        StopMovement();
    }

    private void HandleResetGame(InputAction.CallbackContext context) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    #endregion
}
