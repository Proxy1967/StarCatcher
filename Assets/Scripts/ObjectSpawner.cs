using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private float startSpawnInterval;
    [SerializeField] private float intervalDecayPerSpawn = 0.02f;
    [SerializeField] private float minSpawnInterval = 0.3f;
    private float currentSpawnInterval;
    private float horizontalLimit;
    private float spawnY;
    private float timer;
    
    void Start()
    {
        currentSpawnInterval = startSpawnInterval;
        float cameraHeight = Camera.main.orthographicSize * 2;
        float cameraAspect = Camera.main.aspect;
        float cameraWidth = cameraHeight * cameraAspect;
        float objectHalfWidth = objectPrefab.GetComponent<SpriteRenderer>().bounds.extents.x;
        horizontalLimit = cameraWidth / 2 - objectHalfWidth;
        spawnY = cameraHeight / 2 + objectHalfWidth;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= currentSpawnInterval) {
            float spawnX = Random.Range(-horizontalLimit,horizontalLimit);
            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
            currentSpawnInterval = Mathf.Max(minSpawnInterval, currentSpawnInterval - intervalDecayPerSpawn);
            timer = 0f;
        }
        
    }
}
