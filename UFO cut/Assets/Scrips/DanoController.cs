using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoController : MonoBehaviour
{
    public HeartSyst heart;
    Rigidbody rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Blade")
        {
            heart.vida--;
        }
    }
}
