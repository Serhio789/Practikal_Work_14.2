using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects_Deat : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        transform.position = player.position;   
    }
}
