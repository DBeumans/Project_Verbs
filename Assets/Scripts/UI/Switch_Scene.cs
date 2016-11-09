using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Switch_Scene : MonoBehaviour {

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadScene(int index)
    {
        switch (index)
        {
            case 0: // main menu
                SceneManager.LoadScene(0);
                break;
            case 1: // game scene
                SceneManager.LoadScene(1);
                break;
            case 2: // game over scene
                SceneManager.LoadScene(2);
                break;
        }
    }
}
