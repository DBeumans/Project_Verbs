using UnityEngine;
using System.Collections;

public class PauzeBehaviour : InputBehaviour {

    [SerializeField]
    GameObject PauzePanel; // pauze ui.

    bool _isPauzed;
    public bool IsPauzed { get { return _isPauzed; } set { _isPauzed = value; } }

    void Start()
    {
        PauzePanel.SetActive(false); // hide the pauze panel.
        _isPauzed = false;
        Time.timeScale = 1;
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

    public void PauzeGame(bool value)
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
