using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicLocalization : MonoBehaviour
{
    public Text Apply, Back, Sound, Soundmenu;
    void Start()
    {
        if (PlayerPrefs.GetInt("Language") == 0)
        {
            Apply.text = "Применить";
            Back.text = "Назад";
            Sound.text = "Звук";
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            Apply.text = "Apply";
            Back.text = "Back";
            Sound.text = "Sound";
        }

        if (PlayerPrefs.GetInt("Language") == 2)
        {
            Apply.text = "應用";
            Back.text = "背部";
            Sound.text = "聲音";
        }
        if (PlayerPrefs.GetInt("Language") == 3)
        {
            Apply.text = "применити";
            Back.text = "назад";
            Sound.text = "звуку";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
