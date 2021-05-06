using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    //public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate(){
       // rb.velocity = new Vector3(speed, 0, speed);

        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector3.left);
        }
        else if(Input.GetKey(KeyCode.W)){
            rb.AddForce(Vector3.forward);
        }
        else if(Input.GetKey(KeyCode.S)){
            rb.AddForce(Vector3.back);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb.AddForce(Vector3.right);
        }
    }

}
