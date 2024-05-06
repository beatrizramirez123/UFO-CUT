using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameControllerMenu : MonoBehaviour
{
    public GameObject credPainel;
    public GameObject tuti;
    // Start is called before the first frame update
    public void Teleport(string tp)
    {
        SceneManager.LoadScene(tp);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
        print("funciona");
    }

    public void OpenCredPainel()
    {
        credPainel.SetActive(true);
    }

    public void CloseCredPainel()
    {
        credPainel.SetActive(false);
    }

    public void Opentuti()
    {
        tuti.SetActive(true);
    }

    public void Closetuti()
    {
        credPainel.SetActive(false);
    }
}
