using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    //sound vars go here because pause script is connected to game manager!
    //sound vars
    [SerializeField] private AudioSource sfx;
    [SerializeField] private AudioClip musicSFX;

    public static bool isPaused;

    [SerializeField] private GameObject pauseMenu;

    [SerializeField] private GameObject DifferingButton;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);

        sfx.clip = musicSFX;
        sfx.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            if (!isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    private void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    //public!
   public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    //public!
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
      
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
