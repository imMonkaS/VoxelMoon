using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript2 : MonoBehaviour
{
    public float timer = 0;

    public GameObject secondtext;

    void Start()
    {
        
    }
    
    void Update()
    {
        timer += Time.deltaTime;


        if (PlayerPrefs.GetInt("Language") == 0 && timer > 0 && timer < 4)
        {
            secondtext.GetComponent<Text>().text = "Только вы способны их остановить!";
            secondtext.GetComponent<Text>().resizeTextMaxSize = 25;
        }
        if (PlayerPrefs.GetInt("Language") == 1 && timer > 0 && timer < 4)
        {
            secondtext.GetComponent<Text>().text = "Only you can stop them!";
            secondtext.GetComponent<Text>().resizeTextMaxSize = 25;
        }

        if (PlayerPrefs.GetInt("Language") == 2 && timer > 0 && timer < 4)
        {
            secondtext.GetComponent<Text>().text = "只有你能阻止它們！";
            secondtext.GetComponent<Text>().resizeTextMaxSize = 25;
        }
        if (PlayerPrefs.GetInt("Language") == 3 && timer > 0 && timer < 4)
        {
            secondtext.GetComponent<Text>().text = "Тільки ви здатні їх зупинити!";
            secondtext.GetComponent<Text>().resizeTextMaxSize = 25;
        }


        if (PlayerPrefs.GetInt("Language") == 0 && timer > 4)
        {
            secondtext.GetComponent<Text>().text = "只有你能拯救我們的星球！";
            secondtext.GetComponent<Text>().resizeTextMaxSize = 25;
        }
        if (PlayerPrefs.GetInt("Language") == 1 && timer > 4)
        {
            secondtext.GetComponent<Text>().text = "Тільки ви здатні врятувати нашу планету!";
            secondtext.GetComponent<Text>().resizeTextMaxSize = 25;
        }
    }
}
