using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameControllerMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Teleport(string tp)
    {
        SceneManager.LoadScene(tp);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
