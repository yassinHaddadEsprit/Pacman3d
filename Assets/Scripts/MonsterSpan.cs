using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterSpan : MonoBehaviour
{
    public bool running = true;
    public float seconds;
     GameObject Enemy;
    public GameObject EnemyPrefab;
    //public GameObject MonsterSpawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        // Set the function as running
        running = true;

        // Do the job until running is set to false
        while (true)
        {
            // Do your code
            print("Ran");
            Enemy = null;
            Enemy = Instantiate(EnemyPrefab, transform);
            // wait for seconds
            yield return new WaitForSeconds(seconds);
            
        }
    }
}
