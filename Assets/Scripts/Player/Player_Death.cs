using UnityEngine;
using System.Collections;

public class Player_Death : MonoBehaviour {

    SaveBehaviour _saveBehaviour;
    Switch_Scene _switch_scene;
    SetHighscore _setHighscore;

    void Start()
    {
        _saveBehaviour = GameObject.FindObjectOfType<SaveBehaviour>();
        _switch_scene = GameObject.FindObjectOfType<Switch_Scene>();
        _setHighscore = GameObject.FindObjectOfType<SetHighscore>();
    }

    public void PlayerDeath()
    {
        _setHighscore.SetScore();
        _saveBehaviour.SaveScore();
        _switch_scene.LoadScene(2);
    }
}
