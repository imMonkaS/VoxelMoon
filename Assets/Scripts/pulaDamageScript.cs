using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulaDamageScript : MonoBehaviour
{
   
    void Start()
    {
        
    }


  
    void Update()
    {
        GetComponent<SphereCollider>().radius += 0.2f * Time.deltaTime;    
    }
    private void OnTriggerEnter(Collider other)
    {
        GamerHP h = other.GetComponent<GamerHP>();
        if (h)
            h.damageFromAlien();
        Alien1States s = other.GetComponent<Alien1States>();
        if (s)
            s.inBoom();
    }
}
