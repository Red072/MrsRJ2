using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private float speed = 2;


    // Start is called before the first frame update
    void Start()
    {
       
        Invoke("Flip", 1);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.right * Time.deltaTime * speed;

    }

 
    private void Flip2()
    {
        transform.Rotate(new Vector3(0, -180, 0));

        Invoke("Flip", 1);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Joey"))
        {
            Destroy(gameObject);
        }
    }

    private void Flip()
    {
        transform.Rotate(new Vector3(0, 180, 0));

        Invoke("Flip2", 1);

    }
}
