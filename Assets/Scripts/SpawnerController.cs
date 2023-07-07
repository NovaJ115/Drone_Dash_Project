using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [Header("-Spawn Points-")]
    public GameObject[] birdSpawnPoints;
    public GameObject[] treeSpawnPoints;
    [Header("-Hazard Prefabs-")]
    public GameObject[] birdPrefab;
    public GameObject[] treePrefab;
    [Header("-Spawn Time-")]
    public float birdSpawnMinTime;
    public float birdSpawnMaxTime;

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
            yield return new WaitForSeconds(Random.Range(birdSpawnMinTime, birdSpawnMaxTime));
            Instantiate(birdPrefab[Random.Range(0, birdPrefab.Length)], birdSpawnPoints[Random.Range(0,birdSpawnPoints.Length)].transform.position, birdSpawnPoints[0].transform.rotation);
        }
        
    }
    public IEnumerator TreeSpawn()
    {
        while(gameStart == true)
        {
            yield return new WaitForSeconds(Random.Range(treeSpawnMinTime, treeSpawnMaxTime));
            Instantiate(treePrefab[Random.Range(0, treePrefab.Length)], treeSpawnPoints[Random.Range(0, treeSpawnPoints.Length)].transform.position, treeSpawnPoints[Random.Range(0, treeSpawnPoints.Length)].transform.rotation);
        }
        
    }


}
