using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Scripts : MonoBehaviour
{
    private Animator _animator;
    public GameObject partical_System;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        _animator.SetBool("Coin_S", false);
        partical_System.SetActive(true);
    }
}
