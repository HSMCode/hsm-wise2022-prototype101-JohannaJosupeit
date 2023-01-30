using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDecoy : MonoBehaviour
{
    public GameObject[] myObjects;
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex1 = Random.Range(0, myObjects.Length);
        int randomIndex2 = Random.Range(0, myObjects.Length);
        int randomIndex3 = Random.Range(0, myObjects.Length);
        int randomIndex4 = Random.Range(0, myObjects.Length);
        int randomIndex5 = Random.Range(0, myObjects.Length);
        int randomIndex6 = Random.Range(0, myObjects.Length);
        int randomIndex7 = Random.Range(0, myObjects.Length);

        Vector3 randomSpawnPosition1 = new Vector3(Random.Range(-10, 11), 3, Random.Range(1, 11));
        Vector3 randomSpawnPosition2 = new Vector3(Random.Range(-10, 11), 3, Random.Range(1, 11));
        Vector3 randomSpawnPosition3 = new Vector3(Random.Range(-10, 11), 3, Random.Range(1, 11));
        Vector3 randomSpawnPosition4 = new Vector3(Random.Range(-10, 11), 3, Random.Range(1, 11));
        Vector3 randomSpawnPosition5 = new Vector3(Random.Range(-10, 11), 3, Random.Range(1, 11));
        Vector3 randomSpawnPosition6 = new Vector3(Random.Range(-10, 11), 3, Random.Range(1, 11));
        Vector3 randomSpawnPosition7 = new Vector3(Random.Range(-10, 11), 3, Random.Range(1, 11));

        Instantiate(myObjects[randomIndex1], randomSpawnPosition1, Quaternion.identity);
        Instantiate(myObjects[randomIndex2], randomSpawnPosition2, Quaternion.identity);
        Instantiate(myObjects[randomIndex3], randomSpawnPosition3, Quaternion.identity);
        Instantiate(myObjects[randomIndex4], randomSpawnPosition4, Quaternion.identity);
        Instantiate(myObjects[randomIndex5], randomSpawnPosition5, Quaternion.identity);
        Instantiate(myObjects[randomIndex6], randomSpawnPosition6, Quaternion.identity);
        Instantiate(myObjects[randomIndex7], randomSpawnPosition7, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
