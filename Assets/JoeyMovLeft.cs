using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class JoeyMovLeft : MonoBehaviour
{
    [SerializeField] private Transform PlayerPos;

    private float speedLeft = 10f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Despawn", 1);

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.right * -1 * Time.deltaTime * speedLeft;

    }

    private void Despawn()
    {
        Destroy(gameObject);
    }
}
