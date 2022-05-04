using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public static int score = 0;
    public static float CountDown = 10;
    public static bool TimerOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if(TimerOn == true)
        {
            CountDown -= Time.deltaTime;
            if(CountDown >= 0)
            {
                CountDown -= Time.deltaTime;
            }
            else
            {
                CountDown = 10;
                TimerOn = false;
            }
        }
        else
        {
            CountDown = 10;
            TimerOn = false;
        }
    }
}
