using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    private bool grounded = false;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(5, 0,0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-5, 0,0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 5) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0,-5) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space) && grounded == true)
        {
            transform.position += new Vector3(0, 0.1f,0);
            
        }

        */

        

        //get direction
        var direction = new Vector3();
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize();

        transform.position += direction * speed * Time.deltaTime;

        if(direction != Vector3.zero){
        transform.forward = direction;
        }

    }
    private void OnCollisionEnter(Collision other) {
      if(other.gameObject.tag =="Enemy"){
        transform.position = startPos;
      }
      if(other.gameObject.tag =="Floor"){
        grounded = true;
      }
      else{
        grounded = false;
      }


    }
}
