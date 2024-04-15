using UnityEngine;
using UnityEngine.UI;

public class FireButton : MonoBehaviour
{
    public Cannon cannon; // Reference to the Cannon script

    void Start()
    {
        // Find the Cannon GameObject in the scene if not assigned manually
        if (cannon == null)
            cannon = FindObjectOfType<Cannon>();
    }

    public void OnFireButtonClick()
    {
        // Call the Fire function of the Cannon script
        cannon.Fire(cannon.angle, cannon.force);
    }
}
