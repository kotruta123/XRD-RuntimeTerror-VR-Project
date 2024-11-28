using UnityEngine;
using TMPro;

public class BowlingScoringManager : MonoBehaviour
{
    public TextMeshPro scoreText; // Assign the 3D TextMeshPro in the Inspector
    private int totalScore = 0;

    // Method to update the score
    public void UpdateScore(int pinsKnockedDown)
    {
        totalScore += pinsKnockedDown;
        RefreshScoreText();
    }

    // Method to reset the score
    public void ResetScore()
    {
        totalScore = 0;
        RefreshScoreText();
    }

    // Refresh the score text on the cube
    private void RefreshScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + totalScore;
        }
    }
}
