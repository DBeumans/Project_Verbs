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
        SceneManager.LoadScene(index);
    }
}
