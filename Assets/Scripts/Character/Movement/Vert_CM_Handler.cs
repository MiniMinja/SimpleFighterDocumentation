using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vert_CM_Handler : MonoBehaviour
{
    public float jumpPower;

    InputLookup lookup;
    Rigidbody2D rb;

    bool jumped;

    public float landingTime;
    Sensor groundSensor;
    bool landing;
    bool fullyLanded;

    // Start is called before the first frame update
    void Start()
    {
        lookup = gameObject.GetComponent<InputLookup>();

        rb = gameObject.GetComponent<Rigidbody2D>();

        groundSensor = gameObject.GetComponentInChildren<GroundSensor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(groundSensor.Detected()){
            if(!fullyLanded && !landing){
                StartCoroutine(Land());
            }
        }
        else{
            fullyLanded = false;
        }
    }

    void FixedUpdate()
    {
        if(lookup.Lookup(InputLookup.UP)){
            Jump();
        }
    }

    IEnumerator Land(){
        landing = true;
        yield return new WaitForSeconds(landingTime);
        landing = false;
        fullyLanded = true;
        jumped = false;
    }

    public void Jump(){
        if(!jumped && fullyLanded){
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jumped = true;
        }
    }

    public bool Landed(){
        return fullyLanded;
    }
}
