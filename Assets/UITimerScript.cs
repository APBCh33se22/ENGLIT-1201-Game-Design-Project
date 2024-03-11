using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITimerScript : MonoBehaviour
{
   public float timeRemaining = 600;
   public bool timerIsRunning = false;
   public TextMeshProUGUI timerText;

   private void Start() {
        timerIsRunning = true;
   }

   void Update() {
        if (timerIsRunning) {
            if (timeRemaining > 0) {
                timeRemaining -= Time.deltaTime;
            }
            else {
                Debug.Log("Time has run out");
                timeRemaining = 0;
                timerIsRunning = false;
            }
            DisplayTime(timeRemaining);
        }
   }

   void DisplayTime(float timeToDisplay) {
    timeToDisplay += 1;
    float minutes = Mathf.FloorToInt(timeToDisplay/60);
    float seconds = Mathf.FloorToInt(timeToDisplay%60);
    timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
   }
}
