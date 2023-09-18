using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settingslocalization : MonoBehaviour
{
    public Text SettingsText, AudioText, LanguageText, BackText;
    void Start()
    {
        if (PlayerPrefs.HasKey("Language"))
        {
            if (PlayerPrefs.GetInt("Language") == 0)
            {
                SettingsText.text = "Настройки";
                AudioText.text = "Звуки";
                LanguageText.text = "Язык";
                BackText.text = "Назад";
            }
            if (PlayerPrefs.GetInt("Language") == 1)
            {
                SettingsText.text = "Settings";
                AudioText.text = "Audio";
                LanguageText.text = "Language";
                BackText.text = "Back";
            }

            if (PlayerPrefs.GetInt("Language") == 2)
            {
                SettingsText.text = "設置";
                AudioText.text = "音頻";
                LanguageText.text = "語言";
                BackText.text = "背部";
            }
            if (PlayerPrefs.GetInt("Language") == 3)
            {
                SettingsText.text = "налаштування";
                AudioText.text = "аудiо";
                LanguageText.text = "мова";
                BackText.text = "назад";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
