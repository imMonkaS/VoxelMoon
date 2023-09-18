using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogoScript : MonoBehaviour
{
    public Text SampleText;

    public Color TextColor;

    public float timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 0 && timer < 2)
        {
            TextColor.a += 0.005f;
            SampleText.GetComponent<Text>().color = TextColor;
        }

        if (timer > 3 && timer < 5)
        {
            TextColor.a -= 0.005f;
            SampleText.GetComponent<Text>().color = TextColor;
        }

        if(timer > 5)
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }

        if (Input.anyKey)
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }
}
