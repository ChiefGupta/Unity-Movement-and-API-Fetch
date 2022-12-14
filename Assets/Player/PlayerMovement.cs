using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; //Controls velocity multiplier
    Rigidbody rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //rb equals the rigidbody on the player
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
        float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1
        if (Input.GetButton("Vertical"))
        {
            rb.velocity = new Vector3(0, rb.velocity.y, zMove) * 2 * speed;
        }
        else if (Input.GetButton("Horizontal"))
        {
            rb.velocity = new Vector3(xMove, rb.velocity.y, 0) * speed;
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
