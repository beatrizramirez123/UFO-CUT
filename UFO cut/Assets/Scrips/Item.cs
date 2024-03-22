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

    public float minxY;
    public float maxX;

    private float rotDirecao = 50;

    // Start is called before the first frame update
    void Start()
    {
        minxY = GerenciarCameta.MinX;
        maxX = GerenciarCameta.MaxX;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IntanciarDestruir()
    {
        GameObject tempItem = null;
        GameObject tempTinta = null;

        tempItem = Instantiate(esquerdaItem,transform.position, transform.rotation) as GameObject;
        tempItem.rigidbody2D.AddForce (-transform.right * forca);
        Debug.Log(transform.right);
        //tempItem.rigidbody2D.AddTorque(torque);

        tempItem = Instantiate(direitaItem,transform.position, transform.rotation) as GameObject;
        tempItem.rigidbody2D.AddForce (-transform.right * forca);
        //tempItem.rigidbody2D.AddTorque(torque);

        tempTinta = Instantiate(tinta,new Vector2 (transform.position.x,transform.position.y),(transform.rotation), as GameObject;
    }

}
