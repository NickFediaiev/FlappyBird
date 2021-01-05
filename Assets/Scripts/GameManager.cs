using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    
    public GameObject gameOverCanvas;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance == this)
        {
            Destroy(gameObject);
        }

        //DontDestroyOnLoad(gameObject);
        
        InitializeManager();
    }

    private void InitializeManager()
    {
        if (gameOverCanvas == null)
        {
            Debug.LogError("Canvas GameObject is not assigned");
        }
        else
        {
            gameOverCanvas.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
