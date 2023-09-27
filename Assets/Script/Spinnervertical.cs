using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinnervertical : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0 , 0);
    }
}
