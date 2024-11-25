using UnityEngine;

public class ResetButton3D : MonoBehaviour
{
    public PinResetter pinResetter; // Assign in Inspector

    void OnTriggerEnter(Collider other)
    {
        // Ensure the collider is from the VR hand or interactor
        if (other.CompareTag("PlayerHand") || other.CompareTag("Interactor"))
        {
            pinResetter.ResetPins();
            AnimateButtonPress();
        }
    }

    void AnimateButtonPress()
    {
        // Example: Button moves slightly when pressed
        transform.localPosition += new Vector3(0, -0.05f, 0);
        Invoke(nameof(ResetButtonPosition), 0.2f);
    }

    void ResetButtonPosition()
    {
        transform.localPosition -= new Vector3(0, -0.05f, 0);
    }
}
