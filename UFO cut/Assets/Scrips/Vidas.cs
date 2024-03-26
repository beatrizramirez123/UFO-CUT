using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    public Texture2D[] Vida;
    private int tamanhoVidas;
    private int index = 0;
    private Pontuacao pontos;




    // Start is called before the first frame update
    void Start()
    {
       guiTexture.texture = Vida[0];
        tamanhoVidas = Vida.Length;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Hit()
    {
        ++pontos;
        guiTexture.texture = pontos.ToString();

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
            guiTexture.texture = Vida[index];
            return true;
        }
        else
        {
            return false;
        }

    }
}
