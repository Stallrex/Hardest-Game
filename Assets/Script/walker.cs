using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walker : MonoBehaviour
{
    private List<Vector3> path = new();
    public Transform Path;
    private Vector3 target;
    private int targetIndex =0;
    public float speed = 3;
    [Range(0.1f, 1f)]
    public float minDistance = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        //all points get

        foreach(Transform child in Path){
            path.Add(child.position);
        }
        target = path[0];
    }

    // Update is called once per frame
    void Update()
    {
        var direction = target - transform.position;

        
        transform.position += direction.normalized * speed * Time.deltaTime;
        var distance = direction.magnitude;
        if(distance <= minDistance){
            targetIndex++;

            //check if at the end
            if(targetIndex >= path.Count) targetIndex = 0;
            target = path[targetIndex];
        }
        
    }
}
