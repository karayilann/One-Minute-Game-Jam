using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject MenuPanel;
    [SerializeField] GameObject WinPanel;
    float GameTimeLimmmite = 5f;
   public static bool isGameStart = false;
    void Awake()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStart)
        {
            Time.timeScale = 1;
            MenuPanel.SetActive(false);
        }
        if (Time.time >= GameTimeLimmmite)
        {
            WinPanel.SetActive(true);
            Time.timeScale = 0;
            
        }

    }
    public void gamestarted()
    {
        isGameStart = true;

    }

    public void startagain()
    {
        WinPanel.SetActive(false);
        SceneManager.LoadScene(0);
        isGameStart=false;
        //MenuPanel.SetActive(true);
    }
}
