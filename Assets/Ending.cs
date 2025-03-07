using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            Invoke("EndGame", 3);
        }
        
    }

    private void EndGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Ending");
    }
}
