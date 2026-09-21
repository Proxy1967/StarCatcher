using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] private float fallingSpeed = 6f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 position = transform.position;
        position.y -= fallingSpeed * Time.deltaTime;
        transform.position = position;
        
    }
}
