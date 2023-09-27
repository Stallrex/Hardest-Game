using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathDebbuger : MonoBehaviour
{
    // Start is called before the first frame update

    List<Transform> path = new();



    private void Start() {
        foreach (Transform child in transform){
            path.Add(child);
        }
    }
    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        for (int i = 0; i < path.Count - 1; i++){

            Gizmos.DrawLine(path[i]. position, path[i+1].position);

        }
    }
}
