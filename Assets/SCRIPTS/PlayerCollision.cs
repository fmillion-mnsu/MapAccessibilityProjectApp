using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject car;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == car)
        {
            // Kill the player
            Destroy(gameObject);
        }
    }
}