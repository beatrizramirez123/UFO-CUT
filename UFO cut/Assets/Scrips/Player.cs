using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.Progress;

public class Player : MonoBehaviour
{
    private Vector3 position;
    private bool morte;
    private Pontuacao ponto;
    private Vidas vida;
    //private Pause pause;
    //public GameObject gameOver;
    public AudioClip clipLetra;
    public AudioClip clipNumero;

    private TrailRenderer trail;

    // Start is called before the first frame update
    private void Awake()
    {
        ponto = GameObject.Find();
    }

    void Start()
    {
        trail = GetComponent<TrailRenderer>();
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
                position = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 1));
                transform.position = new Vector2(position.x, position.y);

                GetComponent<Collider2D>().enabled = true;
                return;
            }
            GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            transform.position = new Vector2(position.x, position.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collisor)
    {
        if (collisor.tag == "PodeMata")
        {
            //score Hit();
            collisor.GetComponent<Item>().IntanciarDestruir();
            Audio(clipLetra);
        }
        else if (collisor.tag == "Numero")
        {
            Audio(clipNumero);
            collisor.GetComponent<Inimigo>().Destroy();

            if (vida.Remover())
            {
                GetComponent<Collider2D>().enabled = false;
                Invoke("LoadLevel", 4f);
                ponto.Recorde();
            }
        }
    }

    void Audio(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
    }
    void LoadLevel()
    {

        Application.LoadLevel("menu");

    }
}






