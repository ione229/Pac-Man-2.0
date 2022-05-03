using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WarpScript : MonoBehaviour
{
    public GameObject ChompMan;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            ChompMan.transform.position = new Vector3(9.5f, 0.5f, 0.30f); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
