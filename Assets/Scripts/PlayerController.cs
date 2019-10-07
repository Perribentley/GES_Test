using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 10.0f;
    private float TurnSpeed = 25f;
    private float HorizantalInput;
    private float ForwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get player input
        HorizantalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);
        //Turn vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * HorizantalInput);

    }
}
