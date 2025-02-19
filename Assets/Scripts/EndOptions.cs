using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EndOptions : MonoBehaviour {
    // Editor variables
    [SerializeField]
    private TextMeshProUGUI winnerText;

    // Private variables
    private PongActions actions;

    #region Unity methods
    private void Awake() {
        actions = new PongActions();
        actions.EndMenu.Continue.started += HandleContinue;
        winnerText.SetText(GetWinnerText(PersistentInformation.Instance.GameWinner));
    }

    private void OnEnable() {
        actions.EndMenu.Enable();
    }

    private void OnDisable() {
        actions.EndMenu.Disable();
    }
    #endregion

    #region Private methods
    private void HandleContinue(InputAction.CallbackContext context) {
        SceneManager.LoadScene("MenuScene");
    }
    #endregion

    #region Auxiliar methods
    private string GetWinnerText(GameEntity gameWinner) {
        return gameWinner switch {
            GameEntity.Player1 => "JUGADOR 1\nGANA",
            GameEntity.Player2 => "JUGADOR 2\nGANA",
            GameEntity.AI => "JUGADOR 1\nPIERDE",
            _ => string.Empty,
        };
    }
    #endregion
}
