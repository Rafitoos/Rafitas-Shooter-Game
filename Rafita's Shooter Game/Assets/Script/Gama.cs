using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gama : MonoBehaviour
{
    public float GamaMax = 5f;
    public float velocidade = 3.5f;
    public float vida = 100f;
    public float vidaAtual;

    //public Bullet damage;
    //public PointsControl points;
    public MobSpawn steate;
    void Steate()
    {
        steate = GameObject.Find("MobSpawn").GetComponent<MobSpawn>();
        steate.AddMob(gameObject);

        // GetComponent<Rigidbody>().AddForce(new Vector3(0, -2, 20) * velocidade);
        //if ( )

        {
            // damage = GameObject.Find("Bullet").GetComponent<Bullet>();
            // damage.BulletDano(this);
            // vidaAtual = vida - dano;
        }
        //Destroy(gameObject, 3);
    }
    public void Dano(float valor)
    {
        vidaAtual -= valor;
    }

    void Morre()
    {
        if (vidaAtual <= 0) { Destroy(transform.gameObject); }
    }


    void OnTriggerEnter(Collider obj)
    {

        if (obj.GetComponent<Bullet>())
        {
            Bullet bl = obj.GetComponent<Bullet>();
            vidaAtual -= bl.getDano();
            Morre();
            PointsControl.instance.AddPoints();
        }
        if (obj.GetComponent<Granada>())
        {
            Granada gr = obj.GetComponent<Granada>();
            vidaAtual -= gr.getDano();
            Morre();
            PointsControl.instance.AddPoints();
        }
    }

    void Update()
    {
        transform.Translate(0, 0, velocidade * Time.deltaTime);
    }
}
