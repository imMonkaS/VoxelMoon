using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerPush : MonoBehaviour
{
    
    void Start()
    {
        
    }

    bool died = false;
    public float dieTime = 3;
    public float dieing = 0;
    public float rotate = 0;
    public float rotateps = 40;

    private void OnTriggerEnter(Collider gamer)
    {
        if (gamer.name == "Gamer")
        {
            died = true;
        } 

    }
    void Update()
    {
        if (died)
        {
            GetComponent<Animator>().Play(0);
            GetComponent<CharacterController>().enabled = false;
            dieing += 1 * Time.deltaTime;
            rotate += rotateps * Time.deltaTime;
            if (rotate < 90)
            {
                GetComponent<Transform>().Rotate(0, 0, rotateps * Time.deltaTime);
            }
            if (dieing >= dieTime && rotate >= 90)
            {
                GameObject.Destroy(gameObject);
            }
        }
    }
}
