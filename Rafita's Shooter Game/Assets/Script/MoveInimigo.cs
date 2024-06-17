using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInimigo : MonoBehaviour
{
    public float VelocidadeInim = 5;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Wall_01 (9)");
        transform.Translate(0,0,VelocidadeInim * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
