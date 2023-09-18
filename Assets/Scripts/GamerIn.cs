using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerIn : MonoBehaviour
{
  
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider c)
    {
        if (c.name != "Gamer") return;
        if (c.GetComponent<GamerHP>().hp == c.GetComponent<GamerHP>().maxHP) return;
        c.GetComponent<GamerHP>().onmedkit();
        GameObject.Destroy(gameObject);
    }
}
