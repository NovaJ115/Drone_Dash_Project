using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [Header("-Spawn Points-")]
    public GameObject[] birdSpawnPoints;
    public GameObject[] treeSpawnPoints;
    public GameObject[] questionCoinSpawnPoints;
    public GameObject[] scoreCoinSpawnPoints;
    [Header("-Hazard Prefabs-")]
    public GameObject[] birdPrefab;
    public GameObject[] treePrefab;
    public GameObject questionCoinPrefab;
    public GameObject scoreCoinPrefab;
    [Header("-Spawn Time-")]
    public float birdSpawnMinTime;
    public float birdSpawnMaxTime;
    public float treeSpawnMinTime;
    public float treeSpawnMaxTime;
    public float questionCoinSpawnMinTime;
    public float questionCoinSpawnMaxTime;
    public float scoreCoinSpawnMinTime;
    public float scoreCoinSpawnMaxTime;
    [Header("Has the game started?")]
    public bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        gameStart = true;
        StartCoroutine(CloudSpawn());
        StartCoroutine(TreeSpawn());
        StartCoroutine(QuestionCoinSpawn());
        StartCoroutine(ScoreCoinSpawn());
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

    public IEnumerator QuestionCoinSpawn()
    {
        while (gameStart == true)
        {
            yield return new WaitForSeconds(Random.Range(questionCoinSpawnMinTime, questionCoinSpawnMaxTime));
            Instantiate(questionCoinPrefab, questionCoinSpawnPoints[Random.Range(0, questionCoinSpawnPoints.Length)].transform.position, questionCoinSpawnPoints[Random.Range(0, questionCoinSpawnPoints.Length)].transform.rotation);
        }

    }

    public IEnumerator ScoreCoinSpawn()
    {
        while (gameStart == true)
        {
            yield return new WaitForSeconds(Random.Range(scoreCoinSpawnMinTime, scoreCoinSpawnMaxTime));
            Instantiate(scoreCoinPrefab, scoreCoinSpawnPoints[Random.Range(0, scoreCoinSpawnPoints.Length)].transform.position, scoreCoinSpawnPoints[Random.Range(0, scoreCoinSpawnPoints.Length)].transform.rotation);
        }

    }

    public void Update()
    {
        if(gameStart == false)
        {
            StopAllCoroutines();
        }
    }

}
