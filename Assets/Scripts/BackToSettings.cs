using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToSettings : MonoBehaviour
{
    public Button Back;

    void Start()
    {
        Back.onClick.AddListener(BackOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BackOnClick()
    {
        SceneManager.LoadScene("SettingsScene", LoadSceneMode.Single);
    }
}
