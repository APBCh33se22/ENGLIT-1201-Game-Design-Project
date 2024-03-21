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
   public bool finished = false;

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

   void OnTriggerEnter2D(Collider2D collision) {

    if (collision == GameObject.Find("FinishLine").GetComponent<BoxCollider2D>()) {
        finished = true;
        timerIsRunning = false;
        DisplayTime(timeRemaining);
        Application.Quit();
        //StartCoroutine(waiter());
    }

   }
/*
   IEnumerator waiter()
{   
    yield return new WaitForSeconds(5);
    Application.Quit();

}*/
}
