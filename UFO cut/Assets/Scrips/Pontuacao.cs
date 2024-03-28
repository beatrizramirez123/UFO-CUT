using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private int recorde;
    private static int pontos = 0;
    public GameObject textPontos;
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        image.sprite = "0"; 
        Recorde();

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
    public void Recorde()
    {
        if (pontos > PlayerPrefs.GetInt("Recorde"))
        {
            PlayerPrefs.GetInt("Recorde ,pontos");
        }
        if (textPontos != null)
        {
            textPontos.image.sprite = "Recorde:" + "" + PlayerPrefs.GetInt("Recorde").ToString();

        }


    }
}
