using UnityEngine;
using System.Collections;

public class LevelBase : MonoBehaviour {

    public float maxRotation = 30.0f;
    public float minRotation = 0f;
    public float rotationSpeed = 1.0f;
    private Transform baseTransform;

    // Use this for initialization
    void Start()
    {
        baseTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        BaseRotation();

        BaseClamp();
    }

    void BaseRotation()
    {
        if (Input.GetKey("w"))
        {
            transform.Rotate(Vector3.right * rotationSpeed);
        }

        if (Input.GetKey("s"))
        {
            transform.Rotate(Vector3.left * rotationSpeed);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.forward * rotationSpeed);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.back * rotationSpeed);
        }
    }

    void BaseClamp()
    {       
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
       
        if (transform.eulerAngles.x > maxRotation && transform.eulerAngles.x < 180)
        {
            transform.eulerAngles = new Vector3(maxRotation, 0, transform.eulerAngles.z);
        }

        if (transform.eulerAngles.x < minRotation && transform.eulerAngles.x > 180)
        {
            transform.eulerAngles = new Vector3(minRotation, 0, transform.eulerAngles.z);
        }

        if (transform.eulerAngles.z > maxRotation && transform.eulerAngles.z < 180)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, maxRotation);
        }

        if (transform.eulerAngles.z < minRotation && transform.eulerAngles.z > 180)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, minRotation);
        }        
    }
}
