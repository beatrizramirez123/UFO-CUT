using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PontuationController : MonoBehaviour
{
    public static PontuationController instance;
    public TMP_Text pontuations;

    private void Awake()
    {
        instance = this;
    }
}
