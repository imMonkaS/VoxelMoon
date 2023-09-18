using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveByKeys : MonoBehaviour
{
    public AudioSource feedAS;
    public AudioSource gunAS;
    public UnityEngine.UI.Image ShootBar;
    public GameObject canv;
    public void getMedic()
    {
        
    }
    public GameObject pula;
    CharacterController cc;
    public Transform shoot;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    public float moveSpeed = 20;
    public float rotateSpeed = 10;
    public float jumpForse = 50;
    public float mouseRotSpeed = 100;
    public float maxSpeed = 60;

    public float timeFromLastShoot = 0;
    public float shootdelay = 2;


    public float stepTime = 1;

    float timeFromLastStep = 0;

    public float verticalRotateAngle = 0;

    public float pulaForse = 20;

    Vector3 velocity = new Vector3(0,0,0);

    bool mouseDown = false;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            timeFromLastStep += 1 * Time.deltaTime;
            if (stepTime < timeFromLastStep)
            {
                timeFromLastStep = 0;

            }
        }

        if (cc.isGrounded) velocity.y = 0;

        velocity.Set(
            Input.GetAxis("Horizontal") * moveSpeed,
            cc.isGrounded ? Input.GetAxis("Jump") * jumpForse : velocity.y,
            Input.GetAxis("Vertical") * moveSpeed + velocity.z / 1.5f
            );

        if (velocity.z > maxSpeed) velocity.z = maxSpeed;

        velocity += Physics.gravity * Time.deltaTime;




        cc.Move(transform.rotation * velocity * Time.deltaTime);

        transform.Rotate(
           0,
           Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime
           , 0
           );
        verticalRotateAngle += -Input.GetAxis("Mouse Y") * Time.deltaTime * mouseRotSpeed;

        if (verticalRotateAngle <= 90 && verticalRotateAngle >= -90)
        {
            shoot.Rotate(
            -Input.GetAxis("Mouse Y") * Time.deltaTime * mouseRotSpeed
            , 0
            , 0);
        }
        if (verticalRotateAngle <= -90) verticalRotateAngle = -90;
        if (verticalRotateAngle >= 90) verticalRotateAngle = 90;


        if (Input.GetAxis("Fire1") == 1 && !mouseDown && timeFromLastShoot >= shootdelay)
        {
            timeFromLastShoot = 0;
            GameObject.Instantiate(pula, shoot.transform.position + shoot.transform.rotation * new Vector3(-1.4f, -0.5f, 2.5f), shoot.transform.rotation);
            gunAS.Play();
        }
        timeFromLastShoot += Time.deltaTime;

        if (Input.GetAxis("Fire1") == 0) mouseDown = false;
        if (Input.GetAxis("Fire1") == 1) mouseDown = true;
        if (cc.isGrounded&&(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0))
        {   
            if(!feedAS.isPlaying)
            feedAS.Play();
        }
        else
        {
            feedAS.time = 0;
            feedAS.Pause();
        }
        if (timeFromLastShoot > shootdelay) timeFromLastShoot = shootdelay;

        //HPBar.rectTransform.localScale = new Vector3(x / 200, 1, 1);
        //HPBar.rectTransform.position = new Vector3(x / 2 + 20, HPBar.rectTransform.position.y, HPBar.rectTransform.position.z);

       // float k = timeFromLastShoot / shootdelay * 200;
      
        //ShootBar.rectTransform.localScale = new Vector3(k/200, 1, 1);
       // ShootBar.rectTransform.position = new Vector3(k /2 + 20, ShootBar.rectTransform.position.y, ShootBar.rectTransform.position.z);
    }
}
