using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    [Header("Кнопки")]
    public Button startNewGame;
    public Button loadGameButton;
    public Button settingsButton;
    public Button exitButton;
    public Button exitYes;
    public Button exitNo;

    /*TODO Удалить все объекты панели кроме GameObject т.к. данный метод скрытия панели более удобный*/
    [Header("Панель")]
    public GameObject exitMenu;
    public GameObject settingsMenu;
    public GameObject mainMenu;

    [Header("Загрузить сцену")]
    public int ScaneName;

    private void Start()
    {     
        startNewGame.onClick.AddListener(Play);
        //loadGameButton.onClick.AddListener();
        settingsButton.onClick.AddListener(delegate{ ShowPanel(settingsMenu); });
        exitButton.onClick.AddListener(delegate{ ShowPanel(exitMenu); });
        exitYes.onClick.AddListener(Exit);
        exitNo.onClick.AddListener(delegate{ ClosePanel(exitMenu); });
    }

    void Play()
    {
        SceneManager.LoadScene(ScaneName);
    }

    void Exit()
    {
        Application.Quit();
    }

    public void ShowPanel(GameObject panel)
    {
        /*MyPanel.enabled = true;
        TextPanel.enabled = true;
        YesBtn.enabled = true;
        YesBtnText.enabled = true;
        NoBtn.enabled = true;
        NoBtnText.enabled = true;*/
        panel.SetActive(true);
        if (panel == settingsMenu)
        {
            mainMenu.gameObject.SetActive(false);
        }
}

    void ClosePanel(GameObject panel)
    {
        /* MyPanel.enabled = false;
         TextPanel.enabled = false;
         YesBtn.enabled = false;
         YesBtnText.enabled = false;
         NoBtn.enabled = false;
         NoBtnText.enabled = false;*/
        panel.SetActive(false);
      
       
    }

    /*void OnMouseDown()
    {
        
    }

    void OnMouseUp()
    {
        
    }

    void OnMouseUpAsButton() {
        switch (gameObject.name) {
            case "LoadGameButton":
                Application.Quit();
                // Application.LoadLevel("play");
                break;
            case "ExitButton":
                
                break;
        }     
    }*/

}
