using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedPlatform : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        StartCoroutine(Retract());
    }

    private IEnumerator Retract()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        yield return new WaitForSeconds(1);
        gameObject.SetActive(true);
    }
}
