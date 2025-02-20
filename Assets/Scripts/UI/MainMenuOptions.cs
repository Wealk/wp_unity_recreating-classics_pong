using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {
    // Editor variables
    [SerializeField]
    private TextMeshProUGUI[] options;

    // Private variables
    private PongActions actions;
    private int index;

    #region Unity methods
    private void Awake() {
        actions = new PongActions();

        actions.Menu.OptionMovement.started += HandleOptionMovement;
        actions.Menu.OptionSelection.started += HandleOptionSelection;

        index = 0;
    }

    private void OnEnable() {
        actions.Menu.Enable();
    }

    private void OnDisable() {
        actions.Menu.Disable();
    }
    #endregion

    #region Private methods
    private void HandleOptionSelection(InputAction.CallbackContext context) {
        switch (index) {
            case 0:
                StartOnePlayerGame();
                break;
            case 1:
                StartTwoPlayersGame();
                break;
            case 2:
                ExitGame();
                break;
        }
    }

    private void StartOnePlayerGame() {
        PersistentInformation.Instance.PlayMode = PlayMode.SinglePlayer;
        SceneManager.LoadScene("GameScene");
    }

    private void StartTwoPlayersGame() {
        PersistentInformation.Instance.PlayMode = PlayMode.LocalCoopPlayer;
        SceneManager.LoadScene("GameScene");
    }

    private void ExitGame() {
        Debug.Log("Exit game");
    }

    private void HandleOptionMovement(InputAction.CallbackContext context) {
        var prevValue = index;

        var value = context.ReadValue<float>();
        if (value > 0) index++;
        else if (value < 0) index--;

        if (index < 0) index += options.Length;
        else if (index >= options.Length) index -= options.Length;

        SwapSelection(options[prevValue], options[index]);
    }
    #endregion

    #region Auxiliar functions
    private void SwapSelection(TextMeshProUGUI previousSelection, TextMeshProUGUI currentSelection) {
        var color = previousSelection.color;
        var size = previousSelection.fontSize;

        previousSelection.color = currentSelection.color;
        previousSelection.fontSize = currentSelection.fontSize;
        previousSelection.fontStyle = FontStyles.Normal;

        currentSelection.color = color;
        currentSelection.fontSize = size;
        currentSelection.fontStyle = FontStyles.Bold;
    }
    #endregion
}
