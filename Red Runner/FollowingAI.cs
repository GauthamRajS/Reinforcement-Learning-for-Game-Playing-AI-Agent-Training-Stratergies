using UnityEngine;

public class FollowingAI : MonoBehaviour
{
    public Transform player; // Reference to the player character
    public float moveSpeed = 5f; // AI movement speed
    public float jumpForce = 5f; // Force applied when jumping

    private Rigidbody rb;
    private Vector3 initialPosition;
    private Vector3 initialScale;
    private bool mimicPlayer = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        initialScale = transform.localScale;
    }

    private void Update()
    {
        if (!mimicPlayer)
        {
            if (Time.time >= 3f)
            {
                mimicPlayer = true;
            }
        }
        else
        {
            if (player != null)
            {
                // Copy player's horizontal movement
                float playerHorizontalInput = Input.GetAxis("Horizontal");
                Vector3 playerMovement = new Vector3(playerHorizontalInput, 0f, 0f);
                transform.Translate(playerMovement * moveSpeed * Time.deltaTime);

                // Copy player's jump
                if (Input.GetButtonDown("Jump"))
                {
                    Jump();
                }
            }
        }
    }

    private void Jump()
{
    Debug.Log("Jump function called");
    if (rb != null)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}

}
    
