using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsButtons : MonoBehaviour
{
    public Button Audio, Language, Back;
    void Start()
    {
        Audio.onClick.AddListener(AudioOnClick);
        Language.onClick.AddListener(LanguageOnClick);
        Back.onClick.AddListener(BackOnClick);
    }
    void AudioOnClick()
    {
        SceneManager.LoadScene("Audio", LoadSceneMode.Single);

    }
    void LanguageOnClick()
    {

        SceneManager.LoadScene("Language", LoadSceneMode.Single);
    }
    void BackOnClick()
    {

        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
