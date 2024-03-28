using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{

    public float minSpawnTime;
    public float maxSpawnTime;
    public float upForce = 400f;
    public float leftForce = 200f;
    public GameObject[] items;

    private float minX, maxX;
    private Rigidbody2D itemRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        minX = GerenciarCamera.MinX();
        maxX = GerenciarCamera.MaxX();
        StartCoroutine(InstanciadorCoroutine());
    }

    // Update is called once per frame
    private void Update()
    {
       
    }

    bool RandomItem()
    {
        return items.Length > 0;
    }

    private IEnumerator InstanciadorCoroutine()
    {
        
            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnTime);

            if (RandomItem())
            {
                int index = Random.Range(0, items.Length);
                GameObject item = Instantiate(items[index], new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity) as GameObject;

                itemRigidbody = item.GetComponent<Rigidbody2D>();
                if (item.transform.position.x > 0)
                {
                    itemRigidbody.AddForce(new Vector2(-leftForce, upForce));
                }
                else
                {
                    itemRigidbody.AddForce(new Vector2(leftForce, upForce));
                }
            }

            StartCoroutine(InstanciadorCoroutine());
    }
}
