using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
    public float GranadaMax = 3f;
    public float velocidade = 25f;
    public float dano = 20;
    public float gravidade = 5;

    public GranadaControler statst;
    void Start()
    {
        this.dano = 20;
        statst = GameObject.Find("Box_01 (1)").GetComponent<GranadaControler>();
        if(Time.deltaTime == 10)
        {
            statst.AddGranada(this);
        }
       
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
        transform.Translate(0, 0, Time.deltaTime * gravidade);
        //if ()
        //{ }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}