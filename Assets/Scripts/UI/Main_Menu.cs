using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour {

    [SerializeField]
    GameObject InstructionsPanel;
    [SerializeField]
    GameObject QuitPanel;
    [SerializeField]
    GameObject MainMenuPanel;

    void Start()
    {
        InstructionsPanel.SetActive(false);
        QuitPanel.SetActive(false);

    }

    public void ShowInstructions()
    {
        InstructionsPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }

    public void StartGame(bool value)
    {
        if(value) // yes, start game
        {
            SceneManager.LoadScene(1);
        }
        if(!value)
        {
            InstructionsPanel.SetActive(false);
            ShowMainMenuPanel();
        }
    }

    public void ShowQuitPanel()
    {
        QuitPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }

    public void QuitGame(bool value)
    {
        if(value) // yes, quit.
        {
            Application.Quit();
        }
        else
        {
            QuitPanel.SetActive(false);
            ShowMainMenuPanel();
        }
    }

    public void ShowMainMenuPanel()
    {
        MainMenuPanel.SetActive(true);
    }
}
