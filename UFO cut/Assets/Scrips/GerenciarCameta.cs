using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciarCameta : MonoBehaviour
{

    public Camera cam;
    private static float minX;
    private static float maxX;
    private static float minY;
    private static float maxY;

    private float distanciaZ;

    // Start is called before the first frame update
    void Start()
    {
        distanciaZ = transform.position.z - cam.transform.position.z;
        minX = cam.ScreenToWorldPoint(new Vector3(0, 0, distanciaZ)).x;
        maxX = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, distanciaZ)).x;

        minY = cam.ScreenToWorldPoint(new Vector3(0, 0, distanciaZ)).y;
        maxY = cam.ScreenToWorldPoint(new Vector3(0, Screen.height, distanciaZ)).y;
    }

    public static float MinY
    {
        get { return minY; }
       
    }

    public static float MaxY
    {
        get { return maxY; }
      
    }

    public static float MinX
    { 
        get { return minX; }
       
    }

    public static float MaxX
    {
        get { return maxX; }
       
    }

    }
