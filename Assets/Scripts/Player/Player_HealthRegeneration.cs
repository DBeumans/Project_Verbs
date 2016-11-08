using UnityEngine;
using System.Collections;

public class Player_HealthRegeneration : Player_HealthData {

    int _regenerationPoints = 5;
    bool _isGeneratingHealth = false;

    public bool IsGeneratingHealth { get { return _isGeneratingHealth; } }

    public void StartHealthGeneration()
    {
        StartCoroutine("PlayerHealthGeneration");
    }

    void Update()
    {
        if (PlayerHealth != 100 && !_isGeneratingHealth)
        {
            StartCoroutine(PlayerHealthGeneration());
        }
    }

    IEnumerator PlayerHealthGeneration()
    {
        _isGeneratingHealth = true;
        while(PlayerHealth < 100)
        {
            // add health over time
            PlayerHealth += _regenerationPoints;
            yield return new WaitForSeconds(1f);
        }
        // is at max health.
        _isGeneratingHealth = false;
    }
}
