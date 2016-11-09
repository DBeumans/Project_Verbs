using UnityEngine;
using System.Collections;

public class Game_Over : MonoBehaviour {

    [SerializeField]
    GameObject _gameOver_Panel;

    Switch_Scene _switch_scene;

    void Start()
    {
        _gameOver_Panel.SetActive(true);
        _switch_scene = GameObject.FindObjectOfType<Switch_Scene>();
    }

    public void Restart(int index)
    {
        // restart the game.
        _switch_scene.LoadScene(index);
    }

    public void BackToMainMenu(int index)
    {
        // back to main menu.
        _switch_scene.LoadScene(index);
    }
}
