using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    
    private bool isDead;
    private Vector3 screen;
    public float minY;
    public float maxY;
    public float rotDir;
    // Start is called before the first frame update
    void Start()
    {
        minY = GerenciarCamera.MinY();
        maxY = GerenciarCamera.MaxY();
    }

    // Update is called once per frame
    void Update()
    {
        Remover();
    }
    public void Remover()
    {
        screen = Camera.main.WorldToScreenPoint(transform.position);
        if (isDead && screen.y < minY)
        {
            Destroy(gameObject);
        }
        else
        {
            isDead = true;
        }
        transform.Rotate(new Vector3(0, 0, rotDir) * Time.deltaTime);
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
