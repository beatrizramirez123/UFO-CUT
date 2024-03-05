using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    private Vector3 position;
    private bool morte;
    private Pontuacao ponto;
    private Vidas       vida;
    //private Pause pause;
    //public GameObject gameOver;
    public AudioClip clipLetra;
    public AudioClip clipNumero;

    TrailRenderer trail;
    // Start is called before the first frame update
    void Start()
    {
        trail = this.GetComponent<TrailRenderer>() as TrailRenderer;
        trail.sortingLayerName = "foreground";
    }

    // Update is called once per frame
    void Update()
    {
        Plataforma();
    }
    private void Plataforma()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.touchCount == 1)
            {
                position = Camera.main.ScreenToWorldPoint
                    (new Vector3(Input.GetTouch(0).position.x, position.y, 1));
                transform.position = new Vector2(position.x, position.y);

                Collider2D.enabled = true;
                return;
            }
            Collider2D.enabled = false;
        } else {

            position = Camera.main.ScreenToWorldPoint
                (new Vector3(Input.mousePosition.x
                Input.mousePosition.y)

                transform.position = new Vector2(position.x, position.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "letras") {
            //score.Hit();
            collision.GetComponent<Item>().InstanciaDestruir();
        }
    }
                                
        

    

