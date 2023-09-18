using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuLocalization : MonoBehaviour
{
    public Text PlayText, SettingsText, ExitText;
    void Start()
    {
        if (PlayerPrefs.HasKey("Language"))
        {
            if (PlayerPrefs.GetInt("Language") == 0)
            {
                PlayText.text = "Играть";
                SettingsText.text = "Настройки";
                ExitText.text = "Выйти";
            }
            if (PlayerPrefs.GetInt("Language") == 1)
            {
                PlayText.text = "Play";
                SettingsText.text = "Settings";
                ExitText.text = "Exit";
            }


            if (PlayerPrefs.GetInt("Language") == 2)
            {
                PlayText.text = "玩";
                SettingsText.text = "設置";
                ExitText.text = "出口";
            }
            if (PlayerPrefs.GetInt("Language") == 3)
            {
                PlayText.text = "грати";
                SettingsText.text = "налаштування";
                ExitText.text = "вхiд";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
