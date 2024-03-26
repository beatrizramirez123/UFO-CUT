using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 position;
    private bool morte;
    private Pontuacao pontos;// troquei pq o Pontos tava dando erro ent eu coisei o pontuacao do awake ai para nao me estressar
     private Vidas vidas;
    // private Pause pause;
    //public GameObject gameOver;
    public AudioClip clipCelular;
    public AudioClip clipBorboleta;
    TrailRenderer trail;
    // Start is called before the first frame update
    private void Awake()
    {
        pontos = GameObject.FindGameObjectWithTag("Pontos").GetComponent<Pontuacao>() as Pontuacao;
        vidas = GameObject.FindGameObjectWithTag("Vidas").GetComponent<Vidas>() as Vidas;
    }
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
                                    (new Vector3(Input.GetTouch(0).position.x,
                                                 Input.GetTouch(0).position.y,1));

                transform.position = new Vector2(position.x, position.y);

                GetComponent<Collider2D>().enabled = true;


                return;
            }
            GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            position = Camera.main.ScreenToWorldPoint
                                  (new Vector3(Input.mousePosition.x,
                                               Input.mousePosition.y,0));
            transform.position = new Vector2(position.x, position.y);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collisor)
    {
        if (collisor.tag == "Celular")
        {
            pontos.Hit();

            collisor.GetComponent<Item>().InstanciarDestruir();
            Audio(clipCelular); 
        }
        else if(collisor.tag == "Borboleta")
        {
            Audio(clipBorboleta);
            collisor.GetComponent<Inimigo>().Destroy();
           
            if (!vidas.Remover())
            {
                GetComponent<Collider2D>().enabled = false;
                Invoke("LoadLevel", 4f);
                pontos.Recorde();
            }
        }
        }
        void Audio(AudioClip clip)
        {
          Audio(clip);
            
            AudioSource.PlayClipAtPoint(clip, transform.position,0.2f);
        }
    void LoaldLevel()
    {
        Application.LoadLevel("Menu");
    }

    }



