using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MobSpawn : MonoBehaviour
{
    public GameObject MobRef, MobPoint;
    public GameObject[] Mob;
    public float contMob = 0;
    public float tempoLimt ;
    public float tempo;

    void Start()
    {
        
    }

    public void AddMob(GameObject newMob)
    {
        if (!GameObject.Find("Beta"))
        {
            contMob += Time.deltaTime;
            if (contMob > tempo)
            {
                Instantiate(MobRef, MobPoint.transform.position, MobPoint.transform.rotation);
                contMob = 0;
            }

        }
        if (!GameObject.Find("Gama"))
        {
            contMob += Time.deltaTime;
            if (contMob > tempo)
            {
                Instantiate(MobRef, MobPoint.transform.position, MobPoint.transform.rotation);
                contMob = 0;
            }

        }
        if (!GameObject.Find("Boss"))
        {
            contMob += Time.deltaTime;
            if (contMob > tempo)
            {
                Instantiate(MobRef, MobPoint.transform.position, MobPoint.transform.rotation);
                contMob = 0;
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        AddMob(gameObject);
        //contMob += Time.deltaTime;
        //if (contMob <= contLimitMob)
        //{
            //GameObject tem = Instantiate(MobRef, MobPoint.transform.position, MobPoint.transform.rotation);
           // contMob++;
            
       // }
        
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        {
          // GameObject tem = Instantiate(MobRef, MobPoint.transform.position, MobPoint.transform.rotation);
           Debug.Log("y");
        }

    }

}

