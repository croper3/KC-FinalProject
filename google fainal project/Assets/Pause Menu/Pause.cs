using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    public static bool isPaused; 
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

        }
       
    }
    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void GoToMainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
