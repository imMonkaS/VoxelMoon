using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public GameObject half1;
    public GameObject half2;

    public float moveMax = 10;
    public float moveSpeed = 2;

    float defaultPosition;

    bool gamerIn = false;
    


    void Start()
    {
        GameObject tmp = half1;
        half1 = half2;
        half2 = tmp;

        defaultPosition = half1.transform.localPosition.z;
    }

    void moveDoors(int sign)
    {
        half1.transform.localPosition -= new Vector3(0,0,moveSpeed * Time.deltaTime) * sign;
        half2.transform.localPosition += new Vector3(0,0,moveSpeed * Time.deltaTime) * sign;
        AudioSource AS = GetComponent<AudioSource>();
        if (!AS.isPlaying)
            AS.Play();
    }

    void Update()
    {
        float pos = half1.transform.localPosition.z;
        bool max = pos > defaultPosition + moveMax;
        bool min = pos < defaultPosition;
        if (gamerIn && !max)
            moveDoors(-1);
        if (!gamerIn && !min)
            moveDoors(1);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.name=="Gamer")
        gamerIn = true;   
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.name == "Gamer")
            gamerIn = false;
    }
}
