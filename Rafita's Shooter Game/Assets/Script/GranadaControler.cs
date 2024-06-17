using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GranadaControler : MonoBehaviour
{
    public GameObject granadaRef, granadaPoint;
    public Granada[] granada;
    public float contGranada = 0;
    public float contLimitGranada = 3;

    void Start()
    {

    }

    public void AddGranada(Granada newGranada)
    {
        for (int i = 0; i < granada.Length; i++)
        {
            if (granada[i] == null)
            {
                granada[i] = newGranada;
                break;
            }

        }

    }
    // Update is called once per frame
    void Update()
    {
        contGranada += Time.deltaTime;
        if (contGranada > contLimitGranada)
        {
            contGranada = 0;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject temp = Instantiate(granadaRef, granadaPoint.transform.position, granadaPoint.transform.rotation);
            Debug.Log("z");
        }

    }

}
