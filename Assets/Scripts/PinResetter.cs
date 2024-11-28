using UnityEngine;

public class PinResetter : MonoBehaviour
{
    private Vector3[] initialPositions;
    private Quaternion[] initialRotations;
    private Rigidbody[] pinRigidbodies;

    public GameObject[] pins; 

    void Start()
    {
        // Store initial positions and rotations
        initialPositions = new Vector3[pins.Length];
        initialRotations = new Quaternion[pins.Length];
        pinRigidbodies = new Rigidbody[pins.Length];

        for (int i = 0; i < pins.Length; i++)
        {
            initialPositions[i] = pins[i].transform.position;
            initialRotations[i] = pins[i].transform.rotation;
            pinRigidbodies[i] = pins[i].GetComponent<Rigidbody>();
        }
    }

    public void ResetPins()
    {
        for (int i = 0; i < pins.Length; i++)
        {
            pins[i].transform.position = initialPositions[i];
            pins[i].transform.rotation = initialRotations[i];

            // Reset the Rigidbody
            pinRigidbodies[i].linearVelocity = Vector3.zero;
            pinRigidbodies[i].angularVelocity = Vector3.zero;
        }
    }
}