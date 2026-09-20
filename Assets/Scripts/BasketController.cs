using UnityEngine;
using UnityEngine.InputSystem;


public class BasketController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 basketPosition = transform.position;
        basketPosition.x += moveInput.x * Time.deltaTime * speed;
        transform.position = basketPosition; 
        Debug.Log(moveInput.x);
    }
}
