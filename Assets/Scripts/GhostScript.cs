using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostScript : MonoBehaviour
{
    
    public GameObject Chomp;
    
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(0 < CORE.CountDown && CORE.CountDown < 10)
        {
            if(collision.gameObject.tag.Equals("Player"))
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            CORE.TimerOn = false;
                   
        }
    }
}
