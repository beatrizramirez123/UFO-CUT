using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    // public GameObject bladeTrailPrefab;
    public float minCuttingVelocity = .001f;    
    bool isCutting = false;

    GameObject currentBladeTrail;
    Vector2 previusPosition;
    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }
        if (isCutting)
        {
            UpdateCut();
        }
    }

    void UpdateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;
        float velocity = (newPosition - previusPosition).magnitude + Time.deltaTime;
        if(velocity > minCuttingVelocity)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;
        }
        previusPosition = newPosition;
    }

    void StartCutting()
    {
        isCutting = true;
       // currentBladeTrail = Instantiate(bladeTrailPrefab, transform.position, Quaternion.identity);
       previusPosition = cam.ScreenToViewportPoint(Input.mousePosition);
       circleCollider.enabled = false;
    }

    void StopCutting()
    {
        isCutting = false;
        /*  if (currentBladeTrail != null)
           {
               currentBladeTrail.transform.SetParent(null);

               Destroy(currentBladeTrail, 1f);
           }*/
        circleCollider.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.CompareTag("PodeMata"))
        {
            Vector2 direction = (collision.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
            Instantiate(Celularfruit.celularSlicePrefab, transform.position, rotation);

            Destroy(gameObject);
        }
    }
}
