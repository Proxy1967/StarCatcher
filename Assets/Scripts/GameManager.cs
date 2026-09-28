using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score; 
    
    private void Awake()
    {
        Instance = this;
    }

    public void AddScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
