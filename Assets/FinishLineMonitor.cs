using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineMonitor : MonoBehaviour
{
    public FinishedSO finishedBoolHolder;
    void OnTriggerEnter2D(Collider2D collision) {
    if (collision.tag == "Player") {
        finishedBoolHolder.finishLineReached = true;
        //Application.Quit();
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
