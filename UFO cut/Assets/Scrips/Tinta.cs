using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tinta : MonoBehaviour
{
    public float speed;
    private float alpha;
    private float red;
    private float green;
    private float blue;
    SpriteRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = this.GetComponent<SpriteRenderer>();
       
       _renderer.color = new Color (red, green, blue, alpha);
    }

    // Update is called once per frame
    void Update()
    {
        _renderer.color = new Color(red, green, blue, alpha -= speed * Time.deltaTime);
        if(alpha <= 0)
        {
            Destroy(gameObject);
        }
    }
}
