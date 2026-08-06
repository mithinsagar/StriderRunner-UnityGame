// -----------------------------------------------------------------------------
// Strider Runner
// File   : RestartJourneyConfirmationMenu.cs
// Module : Restart Journey Confirmation Menu
// Author : Mithin Sagar S
// GitHub : https://github.com/mithinsagar
// License: MIT (see LICENSE at project root)
// -----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartJourneyConfirmationMenu : MonoBehaviour
{
    [SerializeField] private Canvas confirmationCanvas;

    public void OpenConfirmationPanel()
    {
        confirmationCanvas.enabled = true;
    }

    public void OnConfirm()
    {
        LevelManager.Instance.ResetLevelProgress();
        SceneManager.LoadScene("Scenes/Start Screen");
        
        PlayerPrefs.SetInt("Character", 0);
        PlayerPrefs.SetInt("LifeCount", 3);
        PlayerPrefs.SetInt("Foods", 0);

        Time.timeScale = 1;
    }

    public void OnReject()
    {
        confirmationCanvas.enabled = false;
    }
}
