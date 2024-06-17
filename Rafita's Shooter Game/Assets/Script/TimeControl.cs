using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeControl : MonoBehaviour
{
    public EndGame EndGame;
    public int timer = 30;
    public TextMeshProUGUI timerText;
    private float timerSync = 0;
    // Start is called before the first frame update
    void Start()
    {
        timerSync = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerSync > 0)
        {
            timerSync -= Time.deltaTime;
        }

        if (timerSync < 0)
        {
            timerSync = 0;
        }
        timer = (int)timerSync;

        timerText.text = "Tempo: " + timer;
        if (timer == 0)
        {
            SceneManager.LoadScene(3);
        }

    }
}
