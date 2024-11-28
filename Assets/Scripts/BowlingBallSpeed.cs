using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class BowlingBallSpeed : MonoBehaviour
{
    public Rigidbody rb;
    public float throwForce = 10f; // Adjust the force as needed

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }

        grabInteractable = GetComponent<XRGrabInteractable>();

        // Listen for release event
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        // Calculate direction and apply force
        Vector3 throwDirection = transform.forward; // Forward direction of the ball
        rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
    }
}
