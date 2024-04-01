using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celularfruit : MonoBehaviour
{
    public static GameObject celularSlicePrefab;
   // Vector2 lastTouchPosition;
   // public Rigidbody2D body;

    void Start()
    {
       // body = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        /* if (Input.GetButtonDown("Fire1"))
         {
             lastTouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         }
         if (Input.GetButtonUp("Fire1"))
         {
             Vector2 newTouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             body.velocity = ((newTouchPosition - lastTouchPosition));
         */
    }




        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Blade"))
            {
                Vector2 direction = (collision.transform.position - transform.position).normalized;

                Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
                Instantiate(celularSlicePrefab, transform.position, rotation);

                Destroy(gameObject);
            }
        }
    }

