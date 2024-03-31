using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Image image;
    private Vector3 position;
    private bool morte;
  
    public AudioClip clipCelular;
    public AudioClip clipBorboleta;
    TrailRenderer trail;
    // Start is called before the first frame update
    private void Awake()
    {
      
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
        if (collisor.tag == "PodeMata")
        {
        

            collisor.GetComponent<Item>().InstanciarDestruir();
            Audio(clipCelular); 
        }
        else if(collisor.tag == "Naopode")
        {
            Audio(clipBorboleta);
            collisor.GetComponent<Inimigo>().Destroy();
           
         
        }
        }
        void Audio(AudioClip clip)
        {
          Audio(clip);
            
            AudioSource.PlayClipAtPoint(clip, transform.position,0.2f);
        }
   

    }



