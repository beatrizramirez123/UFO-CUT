using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celularfruit : MonoBehaviour
{
    public static Celularfruit Instance;
    public GameObject celularSlicePrefab;
    public static int point;
    public string pontuation;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Blade"))
        {
            print("bateu");
            point += 1;
            pontuation = point.ToString();
            PontuationController.instance.pontuations.text = pontuation;
            Vector2 direction = (collision.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);
            GameObject sliceCelular = Instantiate(celularSlicePrefab, transform.position, rotation);
            Destroy(sliceCelular, 3f);
            Destroy(gameObject);

        }
    }

    private void Awake()
    {
        Instance = this;
    }
}

