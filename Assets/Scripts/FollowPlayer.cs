using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Add player object to the script
    public GameObject player;

    // Create Vector3 offset to set the camera position relative to the player
    private Vector3 offset = new Vector3(0, 5, -9);     

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Change to LateUpdate to ensure the camera follows the player after all movement has been calculated
    void LateUpdate()
    {
        // Offset camera is set to follow the player by setting the position of the camera to the position of the player
        transform.position = player.transform.position + offset;
    }
}
