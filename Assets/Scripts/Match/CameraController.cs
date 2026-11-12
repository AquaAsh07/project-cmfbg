using UnityEngine;

/// <summary>
/// LEGACY — Broadcast Camera (Prototype)
/// Smooth follow with broadcast-style angle. Later: dynamic zoom, replays.
/// </summary>
public class CameraController : MonoBehaviour
{
    [Header("Follow")]
    public Transform target;
    public Vector3 offset = new Vector3(0f, 18f, -12f);
    public float smoothing = 4f;

    void LateUpdate()
    {
        if (target == null) return;
        Vector3 desired = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desired, smoothing * Time.deltaTime);
        transform.LookAt(target.position);
    }
}
