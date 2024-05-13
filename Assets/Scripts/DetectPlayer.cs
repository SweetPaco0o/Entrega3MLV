using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public float detectionRadius = 5f; // Radius for player detection

    private void Start()
    {
        // Make sure an animator is assigned
        if (animator == null)
        {
            Debug.LogError("No Animator component found on this object!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if colliding object is the player
        if (other.gameObject.tag == "Player") // Replace "Player" with your actual player tag
        {
            animator.Play("chest"); // Replace "YourAnimationName" with your animation clip name
        }
    }
}