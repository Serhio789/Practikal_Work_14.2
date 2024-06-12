using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pous_Script : MonoBehaviour
{
    private bool Pous_Counter = true;
    public void Click_Pous()
    {
        if (Pous_Counter)
        {
            Time.timeScale = 0f;
            Pous_Counter = false;
        }
        else
        {
            Time.timeScale = 1f;
            Pous_Counter = true;
        }
    }
}
