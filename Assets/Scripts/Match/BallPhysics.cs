using UnityEngine;

/// <summary>
/// LEGACY — Ball Physics (Tech Prototype)
/// Custom-feel ball: drag, bounce, spin, kick, goal detection.
/// Attach to ball sphere. Requires Rigidbody + SphereCollider.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class BallPhysics : MonoBehaviour
{
    [Header("Physics Feel")]
    public float drag = 0.6f;
    public float bounciness = 0.55f;
    public float maxSpeed = 28f;

    [Header("Kick")]
    public float kickLift = 0.18f;

    [Header("Goals (set in inspector)")]
    public Transform leftGoal;
    public Transform rightGoal;
    public float goalWidth = 7.3f;
    public float goalHeight = 2.44f;

    public event System.Action<bool> OnGoal;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        rb.angularDrag = 0.4f;
        var physMat = new PhysicMaterial("BallMat")
        {
            bounciness = bounciness,
            frictionCombine = PhysicMaterialCombine.Average,
            bounceCombine = PhysicMaterialCombine.Average
        };
        var col = GetComponent<Collider>();
        if (col != null) col.material = physMat;
    }

    void FixedUpdate()
    {
        Vector3 v = rb.velocity;
        float hSpeed = new Vector2(v.x, v.z).magnitude;
        if (hSpeed > 0.01f)
        {
            float decel = drag * hSpeed * Time.fixedDeltaTime;
            float newSpeed = Mathf.Max(0f, hSpeed - decel);
            Vector2 dir = new Vector2(v.x, v.z).normalized * newSpeed;
            rb.velocity = new Vector3(dir.x, v.y, dir.y);
        }
        if (rb.velocity.magnitude > maxSpeed)
            rb.velocity = rb.velocity.normalized * maxSpeed;
        float roll = hSpeed * Time.fixedDeltaTime / 0.22f;
        if (hSpeed > 0.1f)
        {
            Vector3 axis = Vector3.Cross(Vector3.up, rb.velocity).normalized;
            transform.RotateAround(transform.position, axis, roll * Mathf.Rad2Deg);
        }
        CheckGoal();
    }

    public void Kick(Vector3 direction, float force)
    {
        direction.y = 0f;
        direction.Normalize();
        Vector3 impulse = direction * force;
        impulse.y += force * kickLift;
        rb.AddForce(impulse, ForceMode.Impulse);
    }

    public void ResetToCenter(Vector3 center)
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = center + Vector3.up * 0.22f;
        transform.rotation = Quaternion.identity;
    }

    void CheckGoal()
    {
        if (leftGoal == null || rightGoal == null) return;
        if (Mathf.Abs(transform.position.z) < goalWidth * 0.5f &&
            transform.position.y < goalHeight)
        {
            if (transform.position.x < leftGoal.position.x - 0.5f)
                OnGoal?.Invoke(true);
            else if (transform.position.x > rightGoal.position.x + 0.5f)
                OnGoal?.Invoke(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        var pc = collision.gameObject.GetComponent<PlayerController>();
        if (pc != null) pc.OnBallTouch(this);
    }
}
