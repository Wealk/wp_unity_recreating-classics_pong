using System;
using UnityEngine;

public class BallController : MonoBehaviour {
    private const float COURT_SIZE = 4.5f;

    // Public variables
    public event Action<Vector2, Vector2> OnBallMovementChange;

    // Editor variables
    [Header("Behaviour")]
    [SerializeField]
    private float initialSpeed;
    [SerializeField]
    private float incrementSpeed;

    [Header("Sounds")]
    [SerializeField]
    private AudioClip paddleCollisionEffect;
    [SerializeField]
    private AudioClip boundCollisionEffect;

    // Private variables
    private new AudioSource audio;
    private new Rigidbody2D rigidbody;
    private float speed;

    #region Unity methods
    private void Awake() {
        audio = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody2D>();
        speed = initialSpeed;
    }

    private void OnCollisionExit2D(Collision2D collision) {
        audio.PlayOneShot(collision.collider.CompareTag("Paddle") ? paddleCollisionEffect : boundCollisionEffect);
        InvokeChangeMovement();
    }
    #endregion

    #region Public calls
    public void ResetBall(Vector2 movementDirection) {
        var courtSize = COURT_SIZE - 0.5f;
        var randomY = UnityEngine.Random.Range(courtSize, -courtSize);
        transform.position = Vector3.up * randomY;

        speed = initialSpeed;
        rigidbody.linearVelocity = movementDirection.normalized * speed;
        InvokeChangeMovement();
    }

    public void NotifyPaddleCollision(float bounceRadians, bool goRight) {
        speed += incrementSpeed;
        rigidbody.angularVelocity = 0;

        var direction = new Vector2(Mathf.Cos(bounceRadians), Mathf.Sin(bounceRadians));
        if (goRight && direction.x < 0 || !goRight && direction.x > 0) direction.x = -direction.x;
        rigidbody.linearVelocity = direction.normalized * speed;
    }
    #endregion

    #region Private methods

    private void InvokeChangeMovement() {
        OnBallMovementChange?.Invoke(transform.position, rigidbody.linearVelocity);
    }
    #endregion
}
