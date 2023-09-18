using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public float timer = 0;

    public GameObject firsttext;
    
    void Start()
    {
    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if (PlayerPrefs.GetInt("Language") == 0 && timer > 0 && timer < 6)
        {
            firsttext.GetComponent<Text>().text = "Шёл 2077 год.Человечество развивалось и, в итоге, им удалось колонизировать луну.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 50;
        }
        if (PlayerPrefs.GetInt("Language") == 1 && timer > 0 && timer < 6)
        {
            firsttext.GetComponent<Text>().text = "It was 2077. Humanity developed and, as a result, they managed to colonize the moon.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 50;
        }

        if (PlayerPrefs.GetInt("Language") == 2 && timer > 0 && timer < 6)
        {
            firsttext.GetComponent<Text>().text = "那是2077年。人類發展了月球。";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 50;
        }
        if (PlayerPrefs.GetInt("Language") == 3 && timer > 0 && timer < 6)
        {
            firsttext.GetComponent<Text>().text = "Йшов 2077 рік. Людство розвивалося і, в підсумку, їм вдалося колонізувати місяць.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 50;
        }


        if (PlayerPrefs.GetInt("Language") == 0 && timer > 6 && timer < 12)
        {
            firsttext.GetComponent<Text>().text = "В это мирное время прибыли пришельцы.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 20;
        }
        if (PlayerPrefs.GetInt("Language") == 1 && timer > 6 && timer < 12)
        {
            firsttext.GetComponent<Text>().text = "The aliens arrived at this time of peace.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 20;
        }

        if (PlayerPrefs.GetInt("Language") == 2 && timer > 6 && timer < 12)
        {
            firsttext.GetComponent<Text>().text = "外星人來到這個和平時期。";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 20;
        }
        if (PlayerPrefs.GetInt("Language") == 3 && timer > 6 && timer < 12)
        {
            firsttext.GetComponent<Text>().text = "У цей мирний час прибутку прибульці.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 20;
        }


        if (PlayerPrefs.GetInt("Language") == 0 && timer > 12 && timer < 15)
        {
            firsttext.GetComponent<Text>().text = "Они собирались захватить Землю и решили начать с её спутника.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 50;
        }
        if (PlayerPrefs.GetInt("Language") == 1 && timer > 12 && timer < 15)
        {
            firsttext.GetComponent<Text>().text = "They were going to take over the Earth and decided to start with her companion.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 50;
        }

        if (PlayerPrefs.GetInt("Language") == 2 && timer > 12 && timer < 15)
        {
            firsttext.GetComponent<Text>().text = "他們打算帶她的同伴。";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 20;
        }
        if (PlayerPrefs.GetInt("Language") == 3 && timer > 12 && timer < 15)
        {
            firsttext.GetComponent<Text>().text = "Вони збиралися захопити Землю і вирішили почати з її супутника.";
            firsttext.GetComponent<Text>().resizeTextMaxSize = 20;
        }
    }
}
