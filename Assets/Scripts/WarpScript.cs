using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WarpScript : MonoBehaviour
{
    public GameObject theOtherWarp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.transform.position = this.theOtherWarp.transform.position; 
        }

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
