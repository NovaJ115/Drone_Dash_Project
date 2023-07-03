using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject birdSpawner;
    public GameObject treeSpawner;

    public GameObject[] birdPrefab;
    public GameObject[] treePrefab;

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
            Instantiate(birdPrefab[Random.Range(0, birdPrefab.Length)], birdSpawner.transform.position, birdSpawner.transform.rotation);
        }
        
    }
    public IEnumerator TreeSpawn()
    {
        while(gameStart == true)
        {
            yield return new WaitForSeconds(Random.Range(treeSpawnMinTime, treeSpawnMaxTime));
            Instantiate(treePrefab[Random.Range(0, treePrefab.Length)], treeSpawner.transform.position, treeSpawner.transform.rotation);
        }
        
    }


}
