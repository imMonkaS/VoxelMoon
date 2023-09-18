using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public Button Game,Exit, Settings;
    void Start()
    {

        Exit.onClick.AddListener(ExitOnclick);
        Game.onClick.AddListener(GameOnclick);
        Settings.onClick.AddListener(SettingsOnClick);
    }

    void GameOnclick()
    {
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }
    void ExitOnclick()
    {
        Application.Quit();
    }

    void SettingsOnClick()
    {
        SceneManager.LoadScene("SettingsScene", LoadSceneMode.Single);
    }

}


