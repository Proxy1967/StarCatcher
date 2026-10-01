using UnityEngine;

public class BasketFlash : MonoBehaviour
{
    [SerializeField] private Color flashColor;
    [SerializeField] private float flashDuration;
    private Color normalColor;
    private SpriteRenderer basket;
    private float timer;
    
    void Start()
    {
        basket = GetComponent<SpriteRenderer>();
        normalColor = basket.color;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                basket.color = normalColor;
            }
        
        }
    }

    public void Flash()
    {
        timer = flashDuration;
        basket.color = flashColor;
    }
}
