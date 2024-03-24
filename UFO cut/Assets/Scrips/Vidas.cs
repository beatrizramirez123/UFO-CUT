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
       GUISkin.skin = Vida[0];//n tem guitext mais cheretei e vi guinskin so n sei se a mesma coisa
        tamanhoVidas = Vida.Length;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Hit()
    {
        ++pontos;
        GUISkin.skin = pontos.ToString();

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
          GUISkin.texture = Vida[index];
            return true;
        }
        else
        {
            return false;
        }

    }
}
