using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celularfruit : MonoBehaviour
{
    public GameObject celularSlicePrefab;
    public float force = 15f;
    Rigidbody2D rb;
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up, ForceMode2D.Impulse);
    }



    void Update()
    {

    }




        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Blade"))
            {
                Vector2 direction = (collision.transform.position - transform.position).normalized;

                Quaternion rotation = Quaternion.LookRotation(direction);
               GameObject sliceCelular = Instantiate(celularSlicePrefab, transform.position, rotation);
                Destroy(sliceCelular, 3f);
                Destroy(gameObject);

            }
        }
    }

