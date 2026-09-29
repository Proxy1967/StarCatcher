using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private float spawnInterval;
    private float horizontalLimit;
    private float spawnY;
    private float timer;
    
    void Start()
    {
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
        if (timer >= spawnInterval) {
            float spawnX = Random.Range(-horizontalLimit,horizontalLimit);
            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
            timer = 0f;
        }
        
    }
}
