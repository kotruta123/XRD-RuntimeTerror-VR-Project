using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ResetButton3D : MonoBehaviour
{
    public PinResetter pinResetter;  // Assign in Inspector
    public BallResetter ballResetter; // Assign in Inspector

    public void OnButtonClick(XRBaseInteractor interactor)
    {
        // Reset both pins and balls
        if (pinResetter != null)
            pinResetter.ResetPins();

        if (ballResetter != null)
            ballResetter.ResetBalls();

    }

   
}
