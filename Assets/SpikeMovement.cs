using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    private float speed = 1.5f;

  
    

    // Start is called before the first frame update
    void Start()
    {
        

        Invoke("startMovement", 1 );
        

    }

    


    private void startMovement()
    {
        transform.position += transform.up  * speed;
        Invoke("StopAllMovement", .5f );
    }

    private void StopAllMovement()
    {
        transform.position += transform.up  * speed * 0;
        Invoke("ResetPos", .75f );
    }
    private void ResetPos()
    {
        transform.position += transform.up  * speed * -1;

        Invoke("StopAgain", .5f );

    }

    private void StopAgain()
    {

        transform.position += transform.up  * speed * 0;
        Invoke("startMovement", 1 );
    }



}
