using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{
    public ParticleSystem ps;

    void Start()
    {
        ps.Emit(1);
    }

    float time = 0;
    public float maxTime = 0.5f;
 
    void Update()
    {
        time += Time.deltaTime;
        if (time >= maxTime) GameObject.Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        GamerHP hp = other.GetComponent<GamerHP>();
        if (hp)
            hp.damageFromBoom();
    }
}
