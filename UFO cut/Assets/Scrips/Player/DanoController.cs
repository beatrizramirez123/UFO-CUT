using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blade")
        {
            HeartSyst.Instance.vida--;
        }
    }
}
