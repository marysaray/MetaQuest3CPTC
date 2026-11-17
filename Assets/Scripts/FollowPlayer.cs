using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Add player object to the script
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Camera is set to follow the player by setting the position of the camera to the position of the player
        transform.position = player.transform.position;
    }
}
