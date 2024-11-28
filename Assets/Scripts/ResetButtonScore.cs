using UnityEngine;

public class ResetButtonScore : MonoBehaviour
{
    public BowlingScoringManager scoringManager; // Assign in Inspector

    public void ResetGame()
    {
        // Reset the score
        if (scoringManager != null)
            scoringManager.ResetScore();

        
    }
}
