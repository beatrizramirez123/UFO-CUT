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
    private SpriteRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();

        _renderer.color = new Color(red, green, blue, alpha);
    }

    // Update is called once per frame
    void Update()
    {
        alpha -= speed * Time.deltaTime;
        _renderer.color = new Color(red, green, blue, alpha);
        if (alpha <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetColor(float _red, float _green, float _blue, float _alpha)
    {
        red = _red;
        green = _green;
        blue = _blue;
        alpha = _alpha;
    }
}
