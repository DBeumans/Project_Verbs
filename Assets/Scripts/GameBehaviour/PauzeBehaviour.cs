using UnityEngine;
using System.Collections;

public class PauzeBehaviour : InputBehaviour {

    [SerializeField]
    GameObject PauzePanel; // pauze ui.

    public bool _isPauzed;

    void Start()
    {
        PauzePanel.SetActive(false); // hide the pauze panel.
        _isPauzed = false;
    }

    void Update() { CheckKeys(); KeyCheck(); }

    void CheckKeys()
    {
        if(EscapeKey)
        {
            if (!_isPauzed)
            {
                PauzeGame(true);
            }
            else if (_isPauzed)
            {
                PauzeGame(false);
            }
        }
    }

    void PauzeGame(bool value)
    {
        if (value) // game pauzed.
        {
            _isPauzed = true;
            PauzePanel.SetActive(true);
            Time.timeScale = 0;
        }
        if(!value) // game unpauzed.
        {
            _isPauzed = false;
            PauzePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
