using UnityEngine;

public class Pin : MonoBehaviour
{
    public ScoringManager scoringManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            scoringManager.AddScore(10); 
        }
    }
}