using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Bullet : MonoBehaviour
{
    public float bulletMax = 10f;
    public float velocidade = 25f;
    public float dano = 20;

    public StatusControl stats;
    void Start()
    {
        this.dano = 20;
        stats = GameObject.Find("pistol2").GetComponent<StatusControl>();
        stats.AddBullet(this);

        // GetComponent<Rigidbody>().AddForce(new Vector3(0, -2, 20) * velocidade);
        Destroy(gameObject, 3);
    }
    public void setDano()
    {
        this.dano = dano * 1.5f;
    }
   
    public float getDano()
    {
        return this.dano;
    }
    void Update()
    {
       transform.Translate(0, 0, velocidade * Time.deltaTime);
       //if ()
       //{ }
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(this.dano);
        Destroy(this.gameObject);
    }


       



}
