using UnityEngine;

public class BallController : MonoBehaviour {
    private const float COURT_SIZE = 4.5f;

    // Editor variables
    [SerializeField]
    private float initialSpeed;
    [SerializeField]
    private float incrementSpeed;

    // Private variables
    private new Rigidbody2D rigidbody;
    private float speed;

    #region Unity methods
    private void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
        speed = initialSpeed;
    }
    #endregion

    #region Public calls
    public void ResetBall(Vector2 movementDirection) {
        var courtSize = COURT_SIZE - 0.5f;
        var randomY = Random.Range(courtSize, -courtSize);
        transform.position = Vector3.up * randomY;

        speed = initialSpeed;
        rigidbody.linearVelocity = movementDirection.normalized * speed;
    }

    public void NotifyPaddleCollision(Vector2 movementDirection) {
        speed += incrementSpeed;
        rigidbody.linearVelocity = movementDirection.normalized * speed;
    }
    #endregion
}
