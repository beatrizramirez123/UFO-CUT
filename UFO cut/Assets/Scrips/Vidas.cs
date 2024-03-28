using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public Sprite[] Vida;
    Image image;
    private int tamanhoVidas;
    private int index = 0;
    private Pontuacao pontos;




    // Start is called before the first frame update
    void Start()
    {
        
        image.sprite = Vida[0];
        tamanhoVidas = Vida.Length;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Hit()
    {
        ++pontos;
        image.sprite = pontos.ToString();

    }

    public bool Remover()
    {
        if ((tamanhoVidas < 0))
        {
            return false;
        }
        if (index < (tamanhoVidas - 1))
        {
            index += 1;
            image.sprite = Vida[index];
            return true;
        }
        else
        {
            return false;
        }

    }
}
