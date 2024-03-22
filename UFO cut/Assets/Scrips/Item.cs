using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject esquerdaItem;
    public GameObject direitaItem;
    public GameObject tinta;

    public float forca;
    public float torque;
    private bool isDead;
    private Vector3 screen;

    public float alpha;
    public float red;
    public float green;
    public float blue;

    public float minY;
    public float maxY;

    private float rotDirecao = 50;

    // Start is called before the first frame update
    void Start()
    {
        minY = GerenciarCamera.MinX;
        maxY = GerenciarCamera.MaxX;
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
    }

    public void IntanciarDestruir()
    {
        GameObject tempItem = Instantiate(esquerdaItem, transform.position, transform.rotation);
        Rigidbody2D tempItemRB = tempItem.GetComponent<Rigidbody2D>();
        tempItemRB.AddForce(-transform.right * forca);
        // tempItemRB.AddTorque(torque);

        tempItem = Instantiate(direitaItem, transform.position, transform.rotation);
        tempItemRB = tempItem.GetComponent<Rigidbody2D>();
        tempItemRB.AddForce(-transform.right * forca);
        // tempItemRB.AddTorque(torque);

        GameObject tempTinta = Instantiate(tinta, new Vector2(transform.position.x, transform.position.y), transform.rotation);
        // tempTinta.GetComponent<tinta>().SetColor(red, green, blue, alpha);

        Destroy(gameObject);
    }
}
