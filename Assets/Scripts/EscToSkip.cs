﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscToSkip : MonoBehaviour
{

    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartSceneContinue", LoadSceneMode.Single);
        }
    }
}
