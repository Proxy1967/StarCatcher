using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int lives = 3;
    public static GameManager Instance;
    private int score; 
    
    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;
    }

    public void AddScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }

    public void LoseLife()
    {
        lives--;
        Debug.Log("Remaining lives: " + lives);
        if (lives <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("GAME OVER");
    }
}
