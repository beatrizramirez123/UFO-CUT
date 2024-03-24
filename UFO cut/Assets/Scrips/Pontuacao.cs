using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    private int recorde;
    private static int pontos = 0;
    public GameObject textPontos;

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        GUISkin.text = "0";
        Recorde();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Hit()
    {
        ++pontos;
        GUISkin.text = pontos.ToString();
    }
    public void Recorde()
    {
        if (pontos > PlayerPrefs.GetInt("Recorde"))
        {
            PlayerPrefs.SetInt("Recorde ,pontos");
        }
        if (textPontos != null)
        {
            textPontos.guiText.text = "Recorde:" + "" + PlayerPrefs.GetInt("Recorde").ToString();

        }


    }
}
