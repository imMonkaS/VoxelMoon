using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien1States : MonoBehaviour
{

    public AudioSource walkAS;
    public AudioSource angreeAS;

    Transform gamer;

    int state = wait;
    const int wait = 0, run = 1, die = 2;
   
    public float waitD = 40;
    public float speed = 20;

    public float dieTime = 3;
    public float dieing = 0;
    public float rotate = 0;
    public float rotateps = 40;

    bool seeGamer()
    {

        float d = (GameObject.FindWithTag("Player").transform.position - transform.position).magnitude;
       
        return d < 40;
    }

    void Start()
    {
       gamer =  GameObject.FindGameObjectWithTag("Player").transform;
        state =wait;
    }

    bool inB = false;

    public void inBoom()
    {
        inB = true;
    }
    
    void Update()
    {
        understandState();
        switch (state)
        {
            case wait:
                onwait();
                break;
            case run:
                onrun();
                break;
            case die:
                ondie();
                break;
        }
    }
    void understandState()
    {
        if (inB)
        {
            state = die;
            
        }else
        {
            
            float d = (transform.position - gamer.position).magnitude;
            if (state == die) return;
            if (!seeGamer())
            {
                GetComponent<Animator>().speed = 0;
                state = wait;
                walkAS.Pause();
            }
            else
            {
                if (state != run)
                {
                    GetComponent<Animator>().speed = 1;
         
                    angreeAS.Play();
                    
                    if(d <= 8)
                    {
                      // GetComponent<Animator>().Play("attak");
                    }
                    else
                    {
                       GetComponent<Animator>().Play("walk");
                    }
                }
                state = run;
            }
        }
    }
    void onwait()
    {
        walkAS.Pause();
    }
    void onrun()
    {
        Transform target = gamer;
        transform.LookAt(new Vector3(target.position.x,transform.position.y,target.position.z));

        Vector3 move = new Vector3(0,0,speed*Time.deltaTime);

        float d = (transform.position - gamer.position).magnitude;
        if (d > 8)
        {
            
            GetComponent<CharacterController>().Move(transform.rotation * move);
            GetComponent<Animator>().Play("walk");
        }
        else 
        {
            //target.GetComponent<GamerHP>().damageFromAlien();
            GetComponent<Animator>().Play("attak");
        }
        
           
    }
    void ondie()
    {
        GetComponent<Animator>().speed = 0;
        GetComponent<CharacterController>().enabled = false;
        dieing += Time.deltaTime;
        rotateps = Mathf.Max(0, rotateps - 50* Time.deltaTime);
        rotate += rotateps * Time.deltaTime;
        if (rotate < 90)
        {
            GetComponent<Transform>().Rotate(0, 0, rotateps * Time.deltaTime);
        }
        if (dieing >= dieTime && rotate >= 90 || rotateps <= 1)
        {
            GameObject.Destroy(gameObject);
        }
       walkAS.Play();
    }
    public void Punch()
    {
        GameObject.FindWithTag("Player").GetComponent<GamerHP>().damageFromAlien();
    }
}
