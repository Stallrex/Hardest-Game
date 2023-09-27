using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float followDistance = 5;

    public bool forget;
    public float forgetDistance = 7;
    private bool follow = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = target.position - transform.position;
        var distance = direction.magnitude;

        if(distance <= followDistance){
            follow = true;
        }
        if(forget && distance > forgetDistance){
            follow = false;
        }
        if(follow){
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;


        }
        
    }
}
