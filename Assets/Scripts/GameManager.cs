using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PinResetter[] pins;
    public float resetDelay = 5f;

    public void ResetPins()
    {
        Invoke(nameof(ResetAllPins), resetDelay);
    }

    void ResetAllPins()
    {
        foreach (var pin in pins)
        {
           // pin.ResetPin();
        }
    }
}