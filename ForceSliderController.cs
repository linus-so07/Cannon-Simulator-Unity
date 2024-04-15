using UnityEngine;
using UnityEngine.UI;

public class ForceSliderController : MonoBehaviour
{
    public Cannon cannon; // Reference to the CannonBall script
    public Slider forceSlider; // Reference to the UI Slider

    void Start()
    {
        // Find the CannonBall GameObject in the scene if not assigned manually
        if (cannon == null)
            cannon = FindObjectOfType<Cannon>();

        // Subscribe to the slider's value changed event
        forceSlider.onValueChanged.AddListener(OnForceSliderValueChanged);
    }

    void OnForceSliderValueChanged(float value)
    {
        // Update the angle value in the CannonBall script
        cannon.force = value;
    }
}
