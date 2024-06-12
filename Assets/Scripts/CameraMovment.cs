using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] private Transform player_Transform;
    private Vector3 off_Sett;

    private void Start()
    {
        off_Sett = transform.position - player_Transform.position;
    }

    private void FixedUpdate()
    {
        transform.position = off_Sett+player_Transform.position;
    }
}
