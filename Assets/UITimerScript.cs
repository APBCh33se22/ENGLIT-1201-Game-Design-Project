using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITimerScript : MonoBehaviour
{
   public float timeRemaining = 300;
   private bool timerIsRunning;
   public TextMeshProUGUI timerText;

   private void Start() {
        timerIsRunning = true;
        
   }

   void Update() { 
        Vector2 pos = GameObject.Find("Player").transform.position;
        if (((pos.y <= 1.857813) && (pos.y >= -1.732331)) && pos.x >= 98.22171) {
            timerIsRunning = false;
        }
        
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
        else {
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
