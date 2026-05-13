using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("Input")]
    [Tooltip("Drag the Move action (Vector2) from the Input System asset here (use an Input Action Reference)")]
    public InputActionReference moveAction;

    [Header("Movement")]
    [Tooltip("Acceleration applied to the rigidbody when input is received (units/s^2)")]
    public float moveAcceleration = 10f;

    [Tooltip("Maximum horizontal speed (m/s). Set to <= 0 to disable clamping.")]
    public float maxSpeed = 6f;

    Rigidbody m_Rigidbody;
    Vector2 m_MoveInput;

    void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        if (m_Rigidbody == null)
            Debug.LogError("PlayerController requires a Rigidbody on the same GameObject.");
    }

    void OnEnable()
    {
        if (moveAction != null && moveAction.action != null)
        {
            moveAction.action.Enable();
            moveAction.action.performed += OnMovePerformed;
            moveAction.action.canceled += OnMovePerformed;
        }
    }

    void OnDisable()
    {
        if (moveAction != null && moveAction.action != null)
        {
            moveAction.action.performed -= OnMovePerformed;
            moveAction.action.canceled -= OnMovePerformed;
            moveAction.action.Disable();
        }
    }

    void OnMovePerformed(InputAction.CallbackContext ctx)
    {
        m_MoveInput = ctx.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
       
            
     
    }
}