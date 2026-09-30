using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int lives = 3;
    [SerializeField] UIManager uiManager;
    public static GameManager Instance;
    private int score; 
    
    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;
    }

    private void Start()
    {
        uiManager.SetScore(score);
        uiManager.SetLives(lives);
    }

    public void AddScore()
    {
        score++;
        uiManager.SetScore(score);
    }

    public void LoseLife()
    {
        lives--;
        uiManager.SetLives(lives);
        if (lives <= 0)
        {
            GameOver(score);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void GameOver(int score)
    {
        Time.timeScale = 0f;
        uiManager.ShowGameOver(score);
    }

}
