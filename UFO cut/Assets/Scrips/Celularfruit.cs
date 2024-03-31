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
            Vector2 direction = (collision.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
            Instantiate(celularSlicePrefab, transform.position, rotation);

            Destroy(gameObject);
        }
    }
}
