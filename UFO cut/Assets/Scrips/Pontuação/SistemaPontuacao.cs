using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPontuacao : MonoBehaviour
{
    public int pontuacao;
    public int pontuacaoAntiga;

    void Start()
    {
        pontuacao = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PodeMata")
        {
        }
    }

    public void SalvarPontos(int pontos)
    {
        
    }
}

