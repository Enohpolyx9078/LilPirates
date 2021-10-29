using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float hInput;
    private float vInput;
    public float speed = 20.0f;
    public float turnSpeed = 10.0f;

    //public float bobSpeed = 1.1f;
    //private string bobber = "DOWN";

    private WeaponController weapon;

    
    void Awake()
    {
         weapon = GetComponent<WeaponController>();    
    }
    
    
    
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
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * hInput);

        if(Input.GetButton("Fire1"))
        {
            if(weapon.CanShoot())
            {
                weapon.Shoot();
            }
        }

        

    }

    void FixedUpdate() {
        //Controls the boat bobbing
        
        // if(transform.position.y > 0f)
        // {
        //     bobber = "DOWN";
        // }

        // else if(transform.position.y < -1f)
        // {
        //     bobber = "UP";
        // }
        
        // if(transform.position.y < 0f & bobber == "UP"){
        //     transform.Translate(Vector3.up * Time.deltaTime * bobSpeed);
        // }

        // else if(transform.position.y > -1f & bobber == "DOWN"){
        //     transform.Translate(Vector3.down * Time.deltaTime * bobSpeed);
        // }
    }
}
