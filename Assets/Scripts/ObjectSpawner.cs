using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject starPrefab;
    private float horizontalLimit;
    private float spawnY;
    private float timer;
    
    void Start()
    {
        float cameraHeight = Camera.main.orthographicSize * 2;
        float cameraAspect = Camera.main.aspect;
        float cameraWidth = cameraHeight * cameraAspect;
        float starHalfWidth = starPrefab.GetComponent<SpriteRenderer>().bounds.extents.x;
        horizontalLimit = cameraWidth / 2 - starHalfWidth;
        spawnY = cameraHeight / 2 + starHalfWidth;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f) {
            float spawnX = Random.Range(-horizontalLimit,horizontalLimit);
            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);
            Instantiate(starPrefab, spawnPosition, Quaternion.identity);
            timer = 0f;
        }
        
    }
}
