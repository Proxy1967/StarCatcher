using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text livesText;
    [SerializeField] private TMP_Text finalScoreText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject hudGroup;


    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }
    public void SetScore(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
    public void SetLives(int newLives)
    {
        livesText.text = "Lives: " + newLives;
    }

    public void ShowGameOver(int finalScore)
    {
        gameOverPanel.SetActive(true);
        hudGroup.SetActive(false);
        finalScoreText.text = "Final Score: " + finalScore;
    }
}
