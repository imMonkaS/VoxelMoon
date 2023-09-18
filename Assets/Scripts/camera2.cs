using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(50,50,50) * Time.deltaTime);
        transform.LookAt(target);
    }
}
