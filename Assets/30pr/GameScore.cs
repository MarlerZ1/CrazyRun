using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private TMP_Text text;

    [SerializeField] private GameObject gameLooseScreen;

    private float _timerStart;
    void Start()
    {
        Time.timeScale = 1f;
        text.text = time.ToString();
        _timerStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float newTime = time - (Time.time - _timerStart);
       
        text.text = (Mathf.Floor(newTime * 100) / 100).ToString();

        if (Mathf.Abs(newTime) < 0.01f)
        {
            Time.timeScale = 0;
            gameLooseScreen.SetActive(true);

        }
    }
}
