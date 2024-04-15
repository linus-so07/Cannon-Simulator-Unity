using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CannonBall : MonoBehaviour
{
    private const float gravAcc = 9.81f;
    private float clock = 0f;
    private Cannon cannon;

    public float x = 0.0f;
    public float y = 0.0f;

    private float velx;
    private float vely;

    public void SetCannonReference(Cannon cannonReference)
    {
        cannon = cannonReference;
        velx = cannon.velx;
        vely = cannon.vely;
    }


    // Update is called once per frame
    void Update()
    {
        if (cannon != null)
        {
            clock += Time.deltaTime;


            float deltaTime = Time.deltaTime;

            vely -= gravAcc * deltaTime;

            // Calculate position using updated velocities
            transform.position += new Vector3(velx * deltaTime, (vely - gravAcc * clock) * deltaTime, 0f);
            vely -= gravAcc * deltaTime;
            Debug.Log(transform.position);
        }
    }
}