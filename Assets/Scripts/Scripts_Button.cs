using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts_Button : MonoBehaviour
{
    private Animator anim;
    private bool chek_B = true;
    public GameObject Stoun;
    private bool check_T = false;
    private float tiimers = 3;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        chek_B=false;
        anim.SetBool("Check_Button", chek_B);
        Stoun.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        chek_B = true;
        anim.SetBool("Check_Button", chek_B);
        check_T = true;
    }
    private void Update()
    {
        if (check_T)
        {
            tiimers -= Time.deltaTime;
            if (tiimers < 0)
            {
                Stoun.SetActive(true);
                check_T = false;
                tiimers = 3;
            }
        }
    }
}
