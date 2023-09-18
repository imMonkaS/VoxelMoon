using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public GameObject prefub;
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<doorScript>()) return;
        Alien1States a = other.GetComponent<Alien1States>();
        if (a)
            a.SendMessage("inBoom");

        GameObject.Instantiate(prefub, transform.position + transform.rotation * new Vector3(2.0f,0,0), transform.rotation);
        GameObject.Destroy(gameObject);
        enabled = false;
    }
}
