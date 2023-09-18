using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamerHP : MonoBehaviour
{
    public Image HPBar;
   
    void Start()
    {
       
        //HPText.text = maxHP.ToString() + "HP";
        hp = maxHP;
    }
    public float hp = 100;
    public float boomDamage = 50;
    public float alienDamage = 10;
    public float medkit = 20;
    public float maxHP = 100;
    public void damageFromBoom()
    {
        hp -= boomDamage;
        if (hp < 0) hp = 0;
    }
    public void damageFromAlien()
    {
        hp -= alienDamage;
        if (hp < 0) hp = 0;
    }
    public void onmedkit()
    {
        hp += medkit;
        if (hp > maxHP)
            hp =maxHP;
    }
    public float timer = 0;
    void onDie()
    {
        timer += Time.deltaTime;
        if(timer > 2)
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }
    void Update()
    {
        if (hp == 0)
        {
            onDie();
        }
       // HPText.text = ((int)hp).ToString()+"HP";
        float x = hp/maxHP*200;
        HPBar.rectTransform.localScale = new Vector3(x/200, 1, 1);
        HPBar.rectTransform.position = new Vector3(x/2 + 20,HPBar.rectTransform.position.y,HPBar.rectTransform.position.z);
        float r, g;
        r = x / 200;
        g = 1 - r;
       
        HPBar.color = new Color(g, r, 0,255);
        float
            st = GetComponent<PlayerMoveByKeys>().timeFromLastShoot,
            mt = GetComponent<PlayerMoveByKeys>().shootdelay;
        x = st / mt * 200;
        Image ShootBar = GetComponent<PlayerMoveByKeys>().ShootBar;
        ShootBar.rectTransform.localScale = new Vector3(x / 200, 1, 1);
        ShootBar.rectTransform.position = new Vector3(x / 2 + 20, ShootBar.rectTransform.position.y, ShootBar.rectTransform.position.z);
        ShootBar.color = new Color(0,0,x/200);
    }
}
