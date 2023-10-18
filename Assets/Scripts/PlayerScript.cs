using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

int MoveSpeed = 6;
[SerializeField] Rigidbody2D rb;
Vector2 Movement;


    void Update()
    {
       Movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    }
    void FixedUpdate(){
       rb.velocity = Movement * MoveSpeed;
    }
}
