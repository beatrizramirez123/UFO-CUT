using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boboletafruit : MonoBehaviour
{
    public GameObject boboletaSlicePrefab;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Blade"))
        {
            print("bateu");
            Vector2 direction = (collision.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);
            GameObject sliceBoboleta = Instantiate(boboletaSlicePrefab, transform.position, rotation);
            Destroy(sliceBoboleta, 3f);
            Destroy(gameObject);

        }
    }
}

