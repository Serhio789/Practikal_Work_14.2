using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Anim : MonoBehaviour
{
    private Animator _anim;
    private int Rand_P = 1;
    private float Time_Play = 2f;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        Time_Play -= Time.deltaTime;
        if (Time_Play <= 0)
        {
        //    Rand_Anim(Rand_P);
            Rand_P = Random.Range(1, 4);
            _anim.SetInteger("rand", Rand_P);
            Time_Play = 2f;
        }
    }
    private void Rand_Anim(int Rand_P)
    {
        if (Rand_P == 1)
        {
            _anim.SetInteger("rand", Rand_P);
            _anim.SetInteger("Well_2", Rand_P);
            _anim.SetInteger("Well_3", Rand_P);
        }
        else if (Rand_P == 2)
        {
            _anim.SetInteger("Wall_1", Rand_P);
            _anim.SetInteger("Well_2", Rand_P);
            _anim.SetInteger("Well_3", Rand_P);
        }
        else if(Rand_P == 3)
        {
            _anim.SetInteger("Wall_1", Rand_P);
            _anim.SetInteger("Well_2", Rand_P);
            _anim.SetInteger("Well_3", Rand_P);
        }
    }
}
