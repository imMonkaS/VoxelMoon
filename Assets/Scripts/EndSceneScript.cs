using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneScript : MonoBehaviour
{
    public Camera PlayerCam, BFRCam;

    public Transform BFRTarget;

    public Animator anim;

    public GameObject BFR;

    public float speed = 5;

    void Start()
    {
        PlayerCam.enabled = false;
        BFRCam.enabled = true;
        this.GetComponent<Animator>().enabled = false;
    }
    public float timer = 0;
    

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0 && timer < 8)
        {
            BFRCam.transform.Rotate(-5.625f * Time.deltaTime, 0, 0);
            BFRCam.transform.Translate(Time.deltaTime,3 * Time.deltaTime, 0);
        }
        if(timer > 8 && timer < 13)
        {
            BFRCam.transform.LookAt(BFRTarget);
            BFRCam.transform.rotation = Quaternion.Euler(0, 66, 0);
            BFRCam.transform.Translate(0, 0, speed * Time.deltaTime);
            BFRCam.transform.Translate(speed * Time.deltaTime, 0, 2 * Time.deltaTime); 
        }
        if(timer > 13 && timer < 21)
        {
            BFRCam.enabled = false;
            PlayerCam.enabled = true;
            this.GetComponent<Animator>().enabled = true;
            anim.Play("Walking");
            if (timer > 13 && timer < 18)
            {
                this.transform.Translate(0, 0, speed * Time.deltaTime * 3);
                PlayerCam.transform.Translate(Time.deltaTime * speed * -3, 0, 0);
            }
            if (timer > 18 && timer < 21) this.GetComponent<Animator>().enabled = false;

            if (timer > 17 && timer < 20)
            {
                PlayerCam.transform.Rotate(-8.865f * Time.deltaTime, -25 * Time.deltaTime, 0);
                PlayerCam.transform.Translate(0, speed * 2.8f * Time.deltaTime, 0);
            }
            if(timer > 20)
            {
                SceneManager.LoadScene("EndScene2", LoadSceneMode.Single);
            }
        }
    }
}
