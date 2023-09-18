using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RusAndEnButts : MonoBehaviour
{
    public int language = 0;

    public Button Rus, En, Chinese, Ukraine;
    public Text LanguageText, ApplyText, BackText;
    void Start()
    {
        Rus.onClick.AddListener(RusOnClick);
        En.onClick.AddListener(EnOnClick);
        Chinese.onClick.AddListener(ChineseOnClick);
        Ukraine.onClick.AddListener(UkraineOnClick);

        if (PlayerPrefs.HasKey("Language"))
        {
            if (PlayerPrefs.GetInt("Language") == 0)
            {
                LanguageText.text = "Язык";
                ApplyText.text = "Применить";
                BackText.text = "Назад";
            }
            if (PlayerPrefs.GetInt("Language") == 1)
            {
                LanguageText.text = "Language";
                ApplyText.text = "Apply";
                BackText.text = "Back";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RusOnClick()
    {
        language = 0;
    }

    void EnOnClick()
    {
        language = 1;
    }

    void ChineseOnClick()
    {
        language = 2;
    }

    void UkraineOnClick()
    {
        language = 3;
    }
    public void applyonclick()
    {
        if (PlayerPrefs.HasKey("Language"))
        {
            if (PlayerPrefs.GetInt("Language") == 0)
            {
                LanguageText.text = "Язык";
                ApplyText.text = "Применить";
                BackText.text = "Назад";
            }
            if (PlayerPrefs.GetInt("Language") == 1)
            {
                LanguageText.text = "Language";
                ApplyText.text = "Apply";
                BackText.text = "Back";
            }

            if (PlayerPrefs.GetInt("Language") == 2)
            {
                LanguageText.text = "語言";
                ApplyText.text = "應用";
                BackText.text = "背部";
            }

            if (PlayerPrefs.GetInt("Language") == 3)
            {
                LanguageText.text = "мова";
                ApplyText.text = "приняти";
                BackText.text = "назад";
            }
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Language", language);
        PlayerPrefs.Save();
    }
}
