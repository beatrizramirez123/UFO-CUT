using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarPontos : MonoBehaviour
{
    public int pontuacao;

    void Start()
    {
        pontuacao = PlayerPrefs.GetInt("Pontos : 0");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print(pontuacao);
        }
    }
}
