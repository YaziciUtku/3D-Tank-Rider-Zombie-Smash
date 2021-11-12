using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    private bool isPaused;
    public GameObject pausePanel;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void PauseGame()
    {
        if (!isPaused)
        {
            isPaused = true;
            pausePanel.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pausePanel.gameObject.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
   










}//CLASS
