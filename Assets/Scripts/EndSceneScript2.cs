using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneScript2 : MonoBehaviour
{
    public float timer = 0, Speed = 5;

    public bool camerachangepos = false;

    public GameObject BFR, zubenko, text;

    public Camera BFRCam;

    void Start()
    {

    }
    

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1 && timer < 3)
        {
            if (!camerachangepos)
            {
                BFRCam.transform.position = new Vector3(439, 42, 304);
                BFRCam.transform.rotation = Quaternion.Euler(0, 0, 0);
                camerachangepos = true;
            }
            
            BFR.transform.Translate(0, Speed * 6 * Time.deltaTime, 0);
            BFRCam.transform.Translate(0, Speed * 6 * Time.deltaTime, 0);
        }
        if(timer > 3 && timer < 5)
        {
            BFR.transform.Translate(0, Speed * 10 * Time.deltaTime, 0);
            BFRCam.transform.Translate(0, Speed * 10 * Time.deltaTime, 0);
        }

        if (timer > 5 && timer < 7)
        {
            BFR.transform.Translate(0, Speed * 14 * Time.deltaTime, 0);
            BFRCam.transform.Translate(0, Speed * 14 * Time.deltaTime, 0);
        }

        if (timer > 7 && timer < 10)
        {
            BFR.transform.Translate(0, Speed * 18 * Time.deltaTime, 0);
            BFRCam.transform.Translate(0, Speed * 18 * Time.deltaTime, 0);
        }

        if (PlayerPrefs.GetInt("Language") == 0 && timer > 10 && timer < 15)
        {
            text.GetComponent<Text>().text = "Ты спас планету!)";
            text.GetComponent<Text>().fontSize = 30;
        }
        if (PlayerPrefs.GetInt("Language") == 1 && timer > 10 && timer < 15)
        {
            text.GetComponent<Text>().text = "You saved the Earth)";
            text.GetComponent<Text>().fontSize = 30;
        }

        if (PlayerPrefs.GetInt("Language") == 2 && timer > 10 && timer < 15)
        {
            text.GetComponent<Text>().text = "你救了這個星球!)";
            text.GetComponent<Text>().fontSize = 30;
        }
        if (PlayerPrefs.GetInt("Language") == 3 && timer > 10 && timer < 15)
        {
            text.GetComponent<Text>().text = "Ти врятував планету!)";
            text.GetComponent<Text>().fontSize = 30;
        }


        if (timer > 10 && timer < 15)
        {
            BFRCam.GetComponent<AudioSource>().enabled = false;
            zubenko.GetComponent<Image>().enabled = true;
            Destroy(BFR);
        }
        if(timer > 15)
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }
}
