using UnityEngine;

public class ScoringManager : MonoBehaviour
{
    public int score = 0;
    public TMPro.TextMeshProUGUI scoreText; // Assign in Inspector

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score.ToString();
    }
}