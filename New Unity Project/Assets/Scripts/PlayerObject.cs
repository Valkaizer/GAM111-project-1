using UnityEngine;
using System.Collections;

public class PlayerObject : MonoBehaviour {

    public float stunTime;
    public float stunCooldown;
    public float chargeTime;
    bool hasBattery;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnCollisionEnter(Collision obstacle)
    {
        string tag = obstacle.gameObject.tag;

        if (tag == "Hazard")
        {
            Stun();
        }

        if (tag == "Battery")
        {
            Carry();
        }
    }

    void Stun()
    {

    }

    void Charge()
    {

    }

    void Carry()
    {

    }
}
