using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public float minSpawTime;
    public float maxSpawTime;
    public float spawnItem;
    private int index;

    public GameObject[] Itens;
    public GameObject item;

    public float upForce = 400f;
    public leftForce = 200f;
    public float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        minX = GerenciarCameta.MinX();
        maxX = GerenciarCameta.MaxX();
    }

    // Update is called once per frame
    private void Update()
    {

    }

    bool RandomItem()
    {
        if (Itens.Length > 0)
        {
            index = Random.Range(0, Itens.Length);
            return true;
        }
        return false;
    }

    private IEnumerator Instanciador ()
    {
        spawnItem = Random.Range(minSpawTime, maxSpawTime);

        yield return new WaitForSeconds(spawnItem);
        if (RandomItem())
        {
            item = Instantiate(Itens[index], new Vector2(Random.Range(min, max).transform.position.y)
                , Quaternion.Euler(0, 0, Random.Range)(-60, 60)))as GameObject;
        }
        if (item.transform.position.x > 0)
        {
            item.rigidbody2D.AddForce(new Vector2(-leftForce,upForce));
        }
        else
        {

        }
    }
}
