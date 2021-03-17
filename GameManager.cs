using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //使用SceneManager.LoadScene來切換場景需要添加

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu; //暫停選單物件
    public GameObject myBag; //背包
    public Canvas canvas_HUD;
   
    private bool isPaused = false; //條件判斷是否暫停遊戲，預設不是暫停狀態
    private bool isOpenBag = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)    //判斷按下ESC鍵時，選單是否開啟狀態來執行暫停或繼續遊戲動作 
            PauseGame();
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
            ContinueGame();
        OpenMybag();
    }

    public void ContinueGame()
    {
        isPaused = false; 
        pauseMenu.SetActive(false);  //關閉離開選單
        Time.timeScale = 1; //時間繼續
    }

    public void PauseGame()
    {
        isPaused = true;
        pauseMenu.SetActive(true); //開啟離開選單
        Time.timeScale = 0; //暫停遊戲
    }


    public void StartGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName); //讀取場景
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit(); //結束遊戲
    }


    void OpenMybag()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            isOpenBag = !isOpenBag; //改變false, true
            myBag.SetActive(isOpenBag);
        }
        
    }

    public void CloseMybagButton()
    {
        isOpenBag = !isOpenBag; //改變false, true
        myBag.SetActive(isOpenBag);
    }
}   