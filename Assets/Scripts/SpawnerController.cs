using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject cloudSpawner;
    public GameObject treeSpawner;

    public GameObject cloudPrefab;
    public GameObject treePrefab;

    public float cloudSpawnMinTime;
    public float cloudSpawnMaxTime;

    public float treeSpawnMinTime;
    public float treeSpawnMaxTime;

    public bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        gameStart = true;
        StartCoroutine(CloudSpawn());
        StartCoroutine(TreeSpawn());
        
    }

    public IEnumerator CloudSpawn()
    {
        while(gameStart == true)
        {
            yield return new WaitForSeconds(Random.Range(cloudSpawnMinTime, cloudSpawnMaxTime));
            Instantiate(cloudPrefab, cloudSpawner.transform.position, cloudSpawner.transform.rotation);
        }
        
    }
    public IEnumerator TreeSpawn()
    {
        while(gameStart == true)
        {
            yield return new WaitForSeconds(Random.Range(treeSpawnMinTime, treeSpawnMaxTime));
            Instantiate(treePrefab, treeSpawner.transform.position, treeSpawner.transform.rotation);
        }
        
    }


}
