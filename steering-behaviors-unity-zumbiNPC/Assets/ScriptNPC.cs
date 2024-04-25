using UnityEngine;

public class ScriptNPC : MonoBehaviour
{
    [SerializeField] float maxSpeed = 6f;
    [SerializeField] float arriveDistance = .4f;

    Animator animator;
    SpriteRenderer sprite;
    Vector2 targetPosition;
    Vector2 delta;
    Vector2 steering;
    Vector2 currentVelocity;

    void Update()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        delta = targetPosition - (Vector2)transform.position;
        Vector2 desiredVelocity = delta.normalized * maxSpeed;

        steering = desiredVelocity - currentVelocity;
        currentVelocity = currentVelocity + steering * Time.deltaTime;
        currentVelocity = Vector2.ClampMagnitude(currentVelocity, maxSpeed);

        float brakingFactor = Mathf.Sqrt(Mathf.Clamp01(delta.magnitude / arriveDistance));
        currentVelocity = currentVelocity * brakingFactor;

        transform.position = transform.position + (Vector3)currentVelocity * Time.deltaTime;

        animator.SetFloat("speed", currentVelocity.magnitude);
        sprite.flipX = currentVelocity.x < 0f;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = delta.magnitude < arriveDistance ? Color.black : Color.white;
        Gizmos.DrawWireSphere(transform.position, arriveDistance);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + currentVelocity);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + steering);
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
}
