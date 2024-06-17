using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class StatusControl : MonoBehaviour
{
    public GameObject bulletRef,bulletPoint;
    public Bullet[]bullet;
    public float contBullet = 0; 
    public float contLimitBullet = 10;
    AudioBehaviour bulletAudio;
    LayerMask Inimigos;
    void Start()
    {
        
    }

    public void AddBullet(Bullet newBullet)
    {
        for(int i = 0; i < bullet.Length ; i++)
        {
            if(bullet[i] == null)
            {
                bullet[i] = newBullet;
                break;
            }
            
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        contBullet += Time.deltaTime;
        if (contBullet > contLimitBullet)
        {
            contBullet = 0;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            AudioBehaviour audio = bulletAudio;
            GameObject temp = Instantiate(bulletRef, bulletPoint.transform.position, bulletPoint.transform.rotation);
            Debug.Log("x");
            //Animator(pistol2_hands_Fire_pistol2);
        }

    }

}
