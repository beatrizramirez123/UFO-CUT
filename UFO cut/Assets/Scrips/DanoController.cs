using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoController : MonoBehaviour
{
    public HeartSyst heart;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "PodeMata")
        {
            heart.vida--;
        }
    }
}
