using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public ParticleSystem particles;

   public  float timeFromStart = 0;
    float dieTime = 3;
    void Start()
    {
        prefub = GetComponent<collision>().prefub;
        particles.Emit(1);
    }
    public GameObject prefub;
    public float speed = 30;
  
    void Update()
    {
        timeFromStart += Time.deltaTime;
        if (timeFromStart > dieTime)
        {
            GameObject.Instantiate(prefub, transform.position + transform.rotation * new Vector3(2.0f, 0, 0), transform.rotation);
            GameObject.Destroy(gameObject);
            enabled = false;
        }
        transform.Translate(new Vector3(0,0,speed*Time.deltaTime));
    }
}
