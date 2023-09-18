using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed = 7, timerforalien = 0, timerforcamera = 0;

    float z = 420;

    public bool playernearalien = false, camerachangestate = false;

    Vector3 moving = Vector3.forward;

    public GameObject alien, gun;

    public Animator animator;

    public Camera cam1;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float Z = transform.position.z;
        if (Z > z) playernearalien = true;
        if (playernearalien)
        {
            animator.Play("Hook");
            timerforalien += Time.deltaTime;
            if(timerforalien > 0.45)
            {
                timerforalien = 1;
                if (!camerachangestate)
                {
                    cam1.transform.position = new Vector3(438, 25, 433);
                    
                    cam1.transform.rotation = Quaternion.Euler(90, -180, 0);
                    camerachangestate = true;
                    Destroy(alien);
                }
                if (camerachangestate)
                {
                    timerforcamera += Time.deltaTime;
                    gun.transform.position = new Vector3(438.87f, 24.98f, 419.69f);
                    gun.transform.rotation = Quaternion.Euler(56.627f, 0, 0);
                }
                if (timerforcamera < 4)
                {
                    cam1.transform.Translate(0, Time.deltaTime, 0);
                    cam1.transform.Rotate(-20 * Time.deltaTime, 0, 0);
                }
                if(timerforcamera > 6)
                {
                    SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
                }
            }
        }
        if (!playernearalien) transform.Translate(moving * speed * Time.deltaTime);

    }
}
