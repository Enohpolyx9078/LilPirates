using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float hInput;
    private float vInput;
    public float speed = 20.0f;
    public float turnSpeed = 10.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //Moves boat around screen
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vInput);
        transform.Rotate(Vector3.up, Time.deltaTime * speed * hInput);

    }
}
