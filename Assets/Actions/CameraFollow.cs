using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset; // distance of the camera to the player
    [SerializeField] private float damping; // smoothness of the camera movement
    public Transform target; // the position of the game object that the camera focusing
    private Vector3 vel = Vector3.zero; // velocity set on (0,0,0)

    private void LateUpdate() // happened after rendering of frame
    {
        Vector3 targetPosition = target.position + offset; //target position is the addition of the player and the distance
        targetPosition.z = transform.position.z;  //to prevent camera to zoom in to player

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping); // smoothly make the camera move the targetPosition
    }

}
