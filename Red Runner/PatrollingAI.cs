using UnityEngine;

public class PatrollingAI : MonoBehaviour
{
    public Transform waypoint1; // First patrol waypoint
    public Transform waypoint2; // Second patrol waypoint
    public float moveSpeed = 5f; // AI movement speed

    private Transform targetWaypoint; // The current target waypoint

    private void Start()
    {
        // Initialize the target waypoint to the first waypoint
        targetWaypoint = waypoint1;
    }

    private void Update()
    {
        // Calculate the direction to the target waypoint
        Vector3 directionToWaypoint = (targetWaypoint.position - transform.position).normalized;

        // Move the AI in the direction of the target waypoint
        transform.Translate(directionToWaypoint * moveSpeed * Time.deltaTime);

        // Check if the AI has reached the target waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            // If so, switch to the other waypoint as the new target
            if (targetWaypoint == waypoint1)
            {
                targetWaypoint = waypoint2;
            }
            else
            {
                targetWaypoint = waypoint1;
            }
        }
    }
}
