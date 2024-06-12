using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WildBall.Inputs
{


    [RequireComponent(typeof(Rigidbody))]
    public class Plaer : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float Speed = 2.0f;
        private Rigidbody player_Rigidbody;
        private Vector3 moveCheck;

        private void Awake()
        {
            player_Rigidbody = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            float harizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            moveCheck = new Vector3(harizontal, 0, vertical);
        }
        private void FixedUpdate()
        {
            MoveCharacter();
        }
        private void MoveCharacter()
        {
            player_Rigidbody.AddForce(moveCheck * Speed);
        }
    }
}
