using UnityEngine;
using UnityEngine.Events;

public class GoalTrigger : MonoBehaviour {
    // Editor variables
    [SerializeField]
    private UnityEvent triggerEvent;

    #region Unity methods
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Ball"))
            triggerEvent.Invoke();
    }
    #endregion
}
