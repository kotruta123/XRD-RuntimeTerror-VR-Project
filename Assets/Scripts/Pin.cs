using UnityEngine;

public class Pin : MonoBehaviour
{
    public BowlingScoringManager scoringManager; // Assign in Inspector

    private bool isKnockedDown = false;

    void OnTriggerEnter(Collider other)
    {
        if (!isKnockedDown && other.CompareTag("Ball"))
        {
            isKnockedDown = true;
            scoringManager.UpdateScore(1); // Add 1 point for each knocked-down pin
        }
    }

    public void ResetPin()
    {
        isKnockedDown = false;
        // Add logic to reset the pin's position and rotation
    }
}
