using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celularfruit : MonoBehaviour
{
    public GameObject celularSlicePrefab;






        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Blade"))
            {
            print("bateu");
                Vector2 direction = (collision.transform.position - transform.position).normalized;

                Quaternion rotation = Quaternion.LookRotation(direction);
               GameObject sliceCelular = Instantiate(celularSlicePrefab, transform.position, rotation);
                Destroy(sliceCelular, 3f);
                Destroy(gameObject);

            }
        }
    }

