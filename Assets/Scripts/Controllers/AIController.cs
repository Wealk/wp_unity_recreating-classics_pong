using UnityEngine;

public class AIController : MonoBehaviour {
    private const int MAX_BOUNCE = 5;

    // Editor variables
    [SerializeField]
    private PaddleController paddle;
    [SerializeField]
    private float distanceOffset;

    // Private variables
    private Vector2 targetPosition;

    #region Unity methods
    private void Awake() {
        var ball = GameObject.FindWithTag("Ball");
        if (ball != null && ball.TryGetComponent<BallController>(out var ballController)) ballController.OnBallMovementChange += HandleBallCollision;
    }

    private void Update() {
        if (targetPosition != Vector2.zero) {
            var distance = Vector2.Distance(targetPosition, paddle.transform.position);
            if (distance >= distanceOffset) HandlePaddleMovement();
            else HandleReleaseMovement();
        }
    }
    #endregion

    #region Private methods
    private void HandlePaddleMovement() {
        if (paddle.transform.position.y > targetPosition.y) paddle.MoveDown();
        else paddle.MoveUp();
    }

    private void HandleReleaseMovement() {
        paddle.StopMovement();
        targetPosition = Vector2.zero;
    }

    private void HandleBallCollision(Vector2 position, Vector2 direction) {
        targetPosition = PredictBallPosition(position, direction);
    }
    #endregion

    #region Auxiliar functions
    private Vector2 PredictBallPosition(Vector2 position, Vector2 direction) {
        if (direction.x > 0) {
            var paddleX = paddle.transform.position.x;
            var collisionWidth = 0.01f;
            var bounceCount = 0;
            while (position.x < paddleX && bounceCount < MAX_BOUNCE) {
                var hit = Physics2D.Raycast(position, direction, Mathf.Abs(paddleX - position.x));
                if (hit.collider != null) {
                    direction = Vector2.Reflect(direction, hit.normal);
                    position = hit.point + (direction.normalized * collisionWidth);
                    bounceCount++;
                } else {
                    var timeToReachPaddle = (paddleX - position.x) / direction.x;
                    position += direction * timeToReachPaddle;
                    break;
                }
            }

            return position;
        }

        paddle.StopMovement();
        return Vector2.zero;
    }
    #endregion
}
