using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public int nextLevelID;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){
        SceneManager.LoadScene(nextLevelID);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
