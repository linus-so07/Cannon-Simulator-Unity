using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cannon : MonoBehaviour
{

    public float velx = 0.0f;
    public float vely = 0.0f;
    public GameObject cannonBallPrefab;
    public float angle = 30f;
    public float force = 30f;
    


    public void Fire(float angle, float velocity)
    {
        float deg2Rad = angle * Mathf.PI * 2 / 360;
        velx = velocity * Mathf.Cos(deg2Rad);
        vely = velocity * Mathf.Sin(deg2Rad);

        GameObject cannonBall = Instantiate(cannonBallPrefab, transform.position, Quaternion.identity);
        CannonBall cannonBallScript = cannonBall.GetComponent<CannonBall>();

        if (cannonBallScript != null)
        {
            cannonBallScript.SetCannonReference(this);
        }
        else
        {
            Debug.LogError("CannonBall script not found on the instantiated object.");
        }
    }
}
