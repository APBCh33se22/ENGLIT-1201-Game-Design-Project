using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLDebugTester : MonoBehaviour
{
    public FinishedSO finishedBoolHolder;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            finishedBoolHolder.finishLineReached=true;
            Debug.Log("Space key was pressed.");
        }
    }
}
