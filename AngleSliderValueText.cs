using UnityEngine;
using UnityEngine.UI;

public class AngleSliderValueText : MonoBehaviour
{
    public Slider slider; // Reference to the UI Slider
    private Text textComponent; // Reference to the Text component

    void Start()
    {
        // Get the Text component attached to this GameObject
        textComponent = GetComponent<Text>();

        if (textComponent == null)
        {
            Debug.LogError("Text component is not found on the GameObject.");
            return;
        }

        // Subscribe to the slider's value changed event
        slider.onValueChanged.AddListener(UpdateText);

        // Update the text initially
        UpdateText(slider.value);
    }

    void UpdateText(float value)
    {
        if (textComponent == null)
        {
            Debug.LogError("Text component is not found on the GameObject.");
            return;
        }

        // Update the text to show the slider's current value
        textComponent.text = "Angle: " + value.ToString("F0");
    }
}
