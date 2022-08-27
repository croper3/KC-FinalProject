using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercollision : MonoBehaviour
{
    
    public GameObject gameoverui;
    public static bool gameispaused;
    
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cactus_B")
        {
           
            gameoverui.SetActive(true);
            Time.timeScale = 0f;
            gameispaused = true;
        }
    }
}
