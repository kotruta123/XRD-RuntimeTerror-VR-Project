using UnityEngine;

public class BallResetter : MonoBehaviour
{
    public GameObject[] balls; // Assign all ball GameObjects in the Inspector

    private Vector3[] initialPositions;
    private Quaternion[] initialRotations;
    private Rigidbody[] ballRigidbodies;

    void Start()
    {
        // Store initial positions and rotations for the balls
        initialPositions = new Vector3[balls.Length];
        initialRotations = new Quaternion[balls.Length];
        ballRigidbodies = new Rigidbody[balls.Length];

        for (int i = 0; i < balls.Length; i++)
        {
            initialPositions[i] = balls[i].transform.position;
            initialRotations[i] = balls[i].transform.rotation;
            ballRigidbodies[i] = balls[i].GetComponent<Rigidbody>();
        }
    }

    public void ResetBalls()
    {
        // Reset the position, rotation, and velocity of each ball
        for (int i = 0; i < balls.Length; i++)
        {
            balls[i].transform.position = initialPositions[i];
            balls[i].transform.rotation = initialRotations[i];

            if (ballRigidbodies[i] != null)
            {
                ballRigidbodies[i].linearVelocity = Vector3.zero;
                ballRigidbodies[i].angularVelocity = Vector3.zero;
            }
        }
    }
}
