using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{
    public GameObject Stats;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        Stats = GameObject.Find("Rock_04");
        if (other.CompareTag("Inimigo"))
        {
            SceneManager.LoadScene(2);
            Debug.Log("inimigo passou");
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Winner()
    {
        SceneManager.LoadScene(3);
    }
    public void Starts()
    {
        SceneManager.LoadScene(1);
    }
}
