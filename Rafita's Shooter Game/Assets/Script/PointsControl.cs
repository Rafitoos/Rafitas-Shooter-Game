using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PointsControl : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI pointsText;
    public static PointsControl instance;
    // Start is called before the first frame update
    void Start()
    {
        //if(gameObject.TryGetComponent<> <= 0);
    }

    // Update is called once per frame
    public void Awake()
    {
        instance = this; 
    }

    public void AddPoints()
    {
        points += 1;
    }
    void Update()
    {
        pointsText.text = "Pontuação: " + points;
        
    }
}
