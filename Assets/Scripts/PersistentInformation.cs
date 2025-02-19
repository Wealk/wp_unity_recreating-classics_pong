using UnityEngine;

public class PersistentInformation : MonoBehaviour {
    // Global properties
    private static PersistentInformation instance;
    public static PersistentInformation Instance => instance;

    // Public properties
    public PlayMode PlayMode { get; set; }
    public GameEntity GameWinner { get; set; }

    #region Unity methods
    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    #endregion
}

public enum PlayMode {
    None,
    SinglePlayer,
    LocalCoopPlayer
}

public enum GameEntity {
    None,
    Player1,
    Player2,
    AI
}
