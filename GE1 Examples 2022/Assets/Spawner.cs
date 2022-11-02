using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int count = 0;
    public GameObject g;
    System.Collections.IEnumerator Spawn()
    {
        if (count < 5)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 13), 5, Random.Range(-8, 8));
            g.AddComponent<Rigidbody>();
            Instantiate(g, randomSpawnPosition, Quaternion.identity);
            g.transform.position = transform.position;
            yield return new WaitForSeconds(.2f);
            count = count + 1;
        }
   
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Spawn());
    }
}
