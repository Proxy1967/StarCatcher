using UnityEngine;

public abstract class FallingObject : MonoBehaviour
{
    [SerializeField] private float fallingSpeed = 6f;
    private float verticalLimit;
    void Start()
    {
        float cameraHalfHeight = Camera.main.orthographicSize;
        float objectHalfHeight = GetComponent<SpriteRenderer>().bounds.extents.y;
        verticalLimit = cameraHalfHeight + objectHalfHeight;
    }

    void Update()
    {
        Vector3 position = transform.position;
        position.y -= fallingSpeed * Time.deltaTime;
        transform.position = position;
        
        if (position.y <= -verticalLimit)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnCaught();
            Destroy(gameObject);
        }
    }

    protected abstract void OnCaught();
}
