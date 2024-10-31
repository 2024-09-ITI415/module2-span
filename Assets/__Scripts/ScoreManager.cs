using UnityEngine;
using TMPro; // Ensure you have this for TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TextMeshPro text object
    private int score;

    void Start()
    {
        score = 0; // Initialize score
        UpdateScoreText(); // Update the UI at the start
    }

    public void AddScore(int points)
    {
        score += points; // Add points to score
        UpdateScoreText(); // Update the UI
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // Update the score text
    }
}
