using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpacecraftEnd : MonoBehaviour
{
    public float speed = 300, timer = 0;

    public Vector3 motion = Vector3.forward;

    public float x = 1329, y = -125, z = 1026;

    public Transform targetspaceship;
    
    public bool end = false;
    

    void Update()
    {
        float X = transform.position.x, Y = transform.position.y, Z = transform.position.z;
        if (Y < y && Z > z)
        {
            end = true;
        }
        if (!end) transform.Translate(motion * speed * Time.deltaTime);
        if (end)
        {
            GetComponent<BoxCollider>().enabled = true;
            Camera.main.transform.position = new Vector3(199, 165, 350);
            timer += Time.deltaTime;
            if(timer > 8)
            {
                SceneManager.LoadScene("StartSceneContinue", LoadSceneMode.Single);
            }
        }
    }
}
