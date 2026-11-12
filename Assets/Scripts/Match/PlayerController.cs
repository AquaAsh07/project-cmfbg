using UnityEngine;

/// <summary>
/// LEGACY — Player Controller (Tech Prototype / Vertical Slice)
/// Top-down 3D player movement with sprint, kick, and gamepad support.
/// Attach to player capsule. Requires Rigidbody (kinematic) + CapsuleCollider.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [Tooltip("Base move speed (units/sec)")]
    public float moveSpeed = 6f;
    [Tooltip("Sprint multiplier")]
    public float sprintMultiplier = 1.6f;
    [Tooltip("Acceleration smoothing")]
    public float acceleration = 12f;

    [Header("Kicking")]
    [Tooltip("Kick force applied to ball")]
    public float kickForce = 14f;
    [Tooltip("Kick range — ball must be within this distance")]
    public float kickRange = 1.6f;
    [Tooltip("Kick cooldown")]
    public float kickCooldown = 0.35f;

    [Header("Ball Reference")]
    public BallPhysics ball;

    [Header("Input")]
    [Tooltip("Player index for gamepad (0 = keyboard + pad 1)")]
    public int playerIndex = 0;

    private Rigidbody rb;
    private float kickTimer;
    private Vector3 moveInput;
    private bool sprintHeld;
    private bool kickPressed;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        rb.isKinematic = true;
    }

    void Update()
    {
        ReadInput();
        kickTimer -= Time.deltaTime;
    }

    void FixedUpdate()
    {
        float speed = moveSpeed * (sprintHeld ? sprintMultiplier : 1f);
        Vector3 targetVel = moveInput * speed;
        Vector3 newVel = Vector3.Lerp(rb.velocity, targetVel, acceleration * Time.fixedDeltaTime);
        rb.velocity = newVel;

        if (moveInput.sqrMagnitude > 0.01f)
        {
            Quaternion targetRot = Quaternion.LookRotation(moveInput, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, 12f * Time.fixedDeltaTime);
        }

        if (kickPressed)
        {
            TryKick();
            kickPressed = false;
        }
    }

    void ReadInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        float padX = Input.GetAxis("Horizontal");
        float padZ = Input.GetAxis("Vertical");
        if (Mathf.Abs(padX) > 0.15f || Mathf.Abs(padZ) > 0.15f)
        {
            x = padX;
            z = padZ;
        }
        moveInput = new Vector3(x, 0f, z);
        if (moveInput.sqrMagnitude > 1f) moveInput.Normalize();
        sprintHeld = Input.GetKey(KeyCode.LeftShift) || Input.GetButton("Fire3");
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            kickPressed = true;
        }
    }

    void TryKick()
    {
        if (kickTimer > 0f || ball == null) return;
        float dist = Vector3.Distance(transform.position, ball.transform.position);
        if (dist > kickRange) return;
        Vector3 kickDir = transform.forward;
        if (moveInput.sqrMagnitude > 0.1f) kickDir = moveInput.normalized;
        kickDir.y = 0f;
        kickDir.Normalize();
        ball.Kick(kickDir, kickForce);
        kickTimer = kickCooldown;
    }

    public void OnBallTouch(BallPhysics b) { }
}
