using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //GameObject Player;
    public float velocidade = 10f;
    //public float alturaPulo = 3;
    //public float tempoPulo = 0.5f;

    //private bool puloAtivo = false;
    //private float contpulo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidade * Time.deltaTime, 0, 0);
            transform.Rotate(0, -0.25f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidade * Time.deltaTime, 0, 0);
            transform.Rotate(0, 0.25f, 0 );
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            GameObject.Find("pistol2").transform.Rotate(0.075f,0, 0 );
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GameObject.Find("pistol2").transform.Rotate(-0.075f, 0, 0);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        transform.Translate(0,0,-1.5f);
        
    }
}
