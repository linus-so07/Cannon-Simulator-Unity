using UnityEngine;
using UnityEngine.UI;

public class AngleSliderController : MonoBehaviour
{
    public Cannon cannon; // Reference to the CannonBall script
    public Slider angleSlider; // Reference to the UI Slider

    void Start()
    {
        // Find the CannonBall GameObject in the scene if not assigned manually
        if (cannon == null)
            cannon = FindObjectOfType<Cannon>();

        // Subscribe to the slider's value changed event
        angleSlider.onValueChanged.AddListener(OnAngleSliderValueChanged);
    }

    void OnAngleSliderValueChanged(float value)
    {
        // Update the angle value in the CannonBall script
        cannon.angle = value;
    }
}
