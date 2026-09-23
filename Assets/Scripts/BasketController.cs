using UnityEngine;
using UnityEngine.InputSystem;


public class BasketController : MonoBehaviour
{
    [SerializeField] private float speed = 12f;
    private float horizontalLimit;
    private InputAction moveAction;

    void Start()
    {
        float cameraHeight = Camera.main.orthographicSize * 2;
        float cameraAspect = Camera.main.aspect;
        float cameraWidth = cameraHeight * cameraAspect;
        float basketHalfWidth = GetComponent<SpriteRenderer>().bounds.extents.x;
        horizontalLimit = cameraWidth / 2 - basketHalfWidth;

        moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 basketPosition = transform.position;
        basketPosition.x += moveInput.x * Time.deltaTime * speed;
        basketPosition.x = Mathf.Clamp(basketPosition.x, -horizontalLimit, horizontalLimit);
        transform.position = basketPosition;
    }
}
