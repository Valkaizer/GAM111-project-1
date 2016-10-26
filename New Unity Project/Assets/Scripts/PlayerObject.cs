using UnityEngine;
using System.Collections;

public class PlayerObject : MonoBehaviour {

    private float timeRemaining;
    public float stunTime;
    public float chargeTime;
    bool hasBattery;
    bool onChargeState;

    public Rigidbody rb;

	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody>();

        onChargeState = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (onChargeState == true)
        {
            Cooldown();
        }      
	}

    void OnCollisionEnter(Collision obstacle)
    {
        string tag = obstacle.collider.tag;

        if (tag == "Hazard" && onChargeState == false)
        {
            Stun();
            Debug.Log("Hazard");
        }

        if (tag == "Battery")
        {
            Carry();
        }

        Debug.Log("Collided");
    }

    void Stun()
    {
        onChargeState = true;
        rb.isKinematic = true;
        timeRemaining = chargeTime;
    }

    void Cooldown()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log("chargeTime" + timeRemaining);

            if (timeRemaining <= 0)
            {
                onChargeState = false;
                Debug.Log("Can be stunned");
            }
        }

        if (timeRemaining < stunTime && rb.isKinematic == true)
        {
            rb.isKinematic = false;
            Debug.Log("I'm free!");
        }
    }

    void Carry()
    {

    }
}
