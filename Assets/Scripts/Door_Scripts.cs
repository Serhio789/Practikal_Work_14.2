using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class Door_Scripts : MonoBehaviour
{
    private Animator anim;
    private bool chek = false;
    public Text text_E;
    private bool chek_Trigger = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            chek_Trigger=true;
    }
    private void OnTriggerExit(Collider other)
    {
        chek_Trigger = false;
    }
    private void Update()
    {
        Click_E();
    }
    private void Click_E()
    {
        if (chek_Trigger) 
        { 
            text_E.text = "E";
            if (Input.GetKeyUp(KeyCode.E))
            {
                chek = !chek;
                anim.SetBool("Check_Pozichen", chek);
            }
        }
        else
            text_E.text = "";
    }
}
