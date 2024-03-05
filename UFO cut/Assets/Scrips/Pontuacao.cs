using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pontuacao : MonoBehaviour
{
    private int recorde;
    private static int pontos = 0;
    public GameObject textPontos;
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        guiText.text = "0";
        Recorde(); 
    }

    public void Hit()
    {
        ++pontos;
        guiText.text = pontos.ToString();

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
//https://www.google.com/search?q=ninja+fruit+em+2d+do+zero&sca_esv=90e47ce38a807d1a&rlz=1C1ISCS_pt-PTBR1098BR1098&sxsrf=ACQVn0-QzyflhalalWsQ8MUOthryxj5VJg%3A1709300090601&ei=etnhZb2kJPrX1sQPyduM0AE&udm=&ved=0ahUKEwi9yduFl9OEAxX6q5UCHcktAxoQ4dUDCBA&uact=5&oq=ninja+fruit+em+2d+do+zero&gs_lp=Egxnd3Mtd2l6LXNlcnAiGW5pbmphIGZydWl0IGVtIDJkIGRvIHplcm8yBRAhGKABMgUQIRigATIFECEYoAFI5hNQxwJY9hJwAXgAkAEAmAGqAaAB6weqAQMwLje4AQPIAQD4AQGYAgegAvYHmAMAiAYBkgcDMC43&sclient=gws-wiz-serp#fpstate=ive&ip=1&vld=cid:ec381ae2,vid:sUBpg0Q_We0,st:0