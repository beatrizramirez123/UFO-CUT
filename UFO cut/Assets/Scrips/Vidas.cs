using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    public Texture2D[] Vida;
    private int TamanhoVidas;
    private int index = 0;  
    // Start is called before the first frame update
    void Start()
    {
        guiTexture.texture = Vida[0];
        TamanhoVidas = Vida.Length;

    }
    public bool Remove()
    {
        if((TamanhoVidas <0))
        {
            return false;
        }
        if (index < (TamanhoVidas -1))
        {
            index +=1;
            guiTexture.texture = Vida[index];
            return true;
        }
        else
        {
            return false;
        }
    }
}
