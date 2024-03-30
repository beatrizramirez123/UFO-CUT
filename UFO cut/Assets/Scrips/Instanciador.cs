using System.Collections;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject[] itens;
    GameObject item;
    int index;

    public float minSpawnTime;
    public float maxSpawnTime;
    public float spawnTime;

    public float upForce = 400f;
    public float leftForce = 200f;
    

    private static float minX, maxX;

    public Rigidbody2D cel;

    // Start is called before the first frame update
    void Start()
    {
        minX = GerenciarCamera.MinX();
        maxX = GerenciarCamera.MaxX();
        StartCoroutine("InstanciadorCoroutine");
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    bool RandomItem()
    {
        if(itens.Length > 0)
        {
            index = Random.Range(0, itens.Length);
            return true;
        }
        return false;
        
    }

    private IEnumerator InstanciadorCoroutine()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);

        yield return new WaitForSeconds(spawnTime);

        if (RandomItem())
        {
            item = Instantiate(itens[index], new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.Euler(0,0,Random.Range(-60, 60)));

            if (item.transform.position.x > 0)
            {
                cel.AddForce(new Vector2(-leftForce, upForce));
            }
            
            else
            {
                cel.AddForce(new Vector2(leftForce, upForce));
            }
            StartCoroutine("InstanciadorCoroutine");
        }   

            
    }
}
