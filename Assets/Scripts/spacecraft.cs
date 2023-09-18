using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacecraft : MonoBehaviour
{
    public float speed = 300, interval = 10;
    public Vector3 motion = Vector3.forward;
    public float x = 1329, y = -122, z = 1094;
    public Transform targetspaceship;
    // Start is called before the first frame update
    void Start()
    {

    }
    public bool end = false;
    // Update is called once per frame
    void Update()
    {
        float X = transform.position.x, Y = transform.position.y, Z = transform.position.z;
        if(Y < y && Z > z)
        {
            end = true;
        }
        if(!end)transform.Translate( motion * speed * Time.deltaTime);
        if (end)
        {
        
            Camera.main.transform.position = new Vector3(300, 546, -34);
            Camera.main.transform.LookAt(targetspaceship);
        }
    }
}
