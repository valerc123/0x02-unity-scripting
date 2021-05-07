using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private int score = 0;
    public int health = 5;
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

    void OnTriggerEnter(Collider other){
        if (other.tag == "Pickup"){
            score++;
            Debug.Log("Score: " + score);
        }
        if (other.tag == "Trap"){
            health--;
            Debug.Log("Health: " + health);
        }
        if(other.tag == "Goal"){
            Debug.Log("You win!");
        }
    }
}
