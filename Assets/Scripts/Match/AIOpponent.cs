using UnityEngine;

/// <summary>
/// LEGACY — Simple AI Opponent (Prototype)
/// Chases ball, kicks toward player's goal. Phase 2: roles, positioning, difficulty.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class AIOpponent : MonoBehaviour
{
    [Header("AI")]
    public float moveSpeed = 5f;
    public float kickForce = 12f;
    public float kickRange = 1.6f;
    public float thinkInterval = 0.15f;

    [Header("Refs")]
    public BallPhysics ball;
    public Transform attackGoal;

    private Rigidbody rb;
    private float thinkTimer;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        rb.isKinematic = true;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    }

    void FixedUpdate()
    {
        if (ball == null) return;
        thinkTimer -= Time.fixedDeltaTime;
        if (thinkTimer > 0f) return;
        thinkTimer = thinkInterval;

        Vector3 toBall = ball.transform.position - transform.position;
        float dist = toBall.magnitude;

        if (dist > kickRange)
        {
            Vector3 dir = toBall.normalized; dir.y = 0f;
            rb.velocity = dir * moveSpeed;
            transform.rotation = Quaternion.LookRotation(dir);
        }
        else
        {
            rb.velocity = Vector3.zero;
            Vector3 kickDir = (attackGoal.position - ball.transform.position).normalized;
            kickDir.y = 0f;
            ball.Kick(kickDir, kickForce);
        }
    }
}
