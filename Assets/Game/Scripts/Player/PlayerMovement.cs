using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private InputManager _input;
    [SerializeField]
    private float _walkSpeed;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _input.OnMoveInput += Move;
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnDestroy()
    {
        _input.OnMoveInput -= Move;
    }

    private void Move(Vector2 axisDirection)
    {
        Vector3 movementDirection = new Vector3(axisDirection.x, 0, axisDirection.y);
        _rigidbody.AddForce(movementDirection * _walkSpeed * Time.deltaTime);
    }
}
