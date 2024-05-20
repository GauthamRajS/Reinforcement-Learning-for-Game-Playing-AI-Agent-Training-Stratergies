using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    public Transform player; // Reference to the player character
    public float moveSpeed = 50f; // AI movement speed

    private void Update()
    {
        if (player != null)
        {
            // Calculate the direction from the AI to the player
            Vector3 directionToPlayer = (player.position - transform.position).normalized;

            // Debugging statements to check values
            Debug.Log("AI Position: " + transform.position);
            Debug.Log("Player Position: " + player.position);
            Debug.Log("Direction to Player: " + directionToPlayer);

            // Move the AI in the direction of the player
            transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
        }
    }
}
