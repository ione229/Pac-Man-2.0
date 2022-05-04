using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChompScript : MonoBehaviour
{
    Rigidbody rb;
    TextMesh theScoreTextMesh;
    public GameObject Enemy1;
    private NavMeshAgent blueGhostAgent;
    
    public GameObject scoreText;
    public float speed = 2.0f;
    

    private bool goForward = false;
    private bool goBackward = false;
    private bool goRight = false;
    private bool goLeft = false;

    void Awake()
    {
        blueGhostAgent = this.Enemy1.GetComponent<NavMeshAgent>();
        blueGhostAgent.speed = 2.0f;
        rb = this.gameObject.GetComponent<Rigidbody>();
        this.theScoreTextMesh = this.scoreText.GetComponent<TextMesh>();
    }

    // Start is called before the first frame update
    void Start()
    {
        blueGhostAgent.SetDestination(this.gameObject.transform.position);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(CORE.CountDown == 0 || CORE.CountDown == 10)
        {
            if(collision.gameObject.tag.Equals("Enemy"))
            {
                Destroy(this.gameObject);
                blueGhostAgent = null;
                print("YOU LOSE.");
            }
        }  
    }

    // Update is called once per frame
    
    
    void Update()
    {

        if (goForward)
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if(goBackward)
        {
            rb.velocity = Vector3.back * speed;
        }
        else if(goLeft)
        {
            rb.velocity = Vector3.left * speed;
        }
        else if(goRight)
        {
            rb.velocity = Vector3.right * speed;
        }

        if (Input.GetKeyDown("up"))
        {
            this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.up);
            goForward = true;
            goBackward = false;
            goRight = false;
            goLeft = false;
            
        }
        else if (Input.GetKeyDown("down"))
        {
            this.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.up);

            goForward = false;
            goBackward = true;
            goRight = false;
            goLeft = false;
            
        }
        else if (Input.GetKeyDown("left"))
        {
            this.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.right);

            goForward = false;
            goBackward = false;
            goRight = false;
            goLeft = true;
            
        }
        else if (Input.GetKeyDown("right"))
        {
            this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.right);

            goForward = false;
            goBackward = false;
            goRight = true;
            goLeft = false;
            
        }
    }
}