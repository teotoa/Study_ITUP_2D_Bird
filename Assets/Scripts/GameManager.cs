using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    static public GameManager instance;

    public GameObject wallPrefab;
    public GameObject wallPrefab2;
    public GameObject wallPrefab3;

    public float spawnTerm = 3;

    GameObject[] objectsToSpawn;

    public TextMeshProUGUI scoreLabel;

    public float score;

    float spawnTimer;


    void Awake()
    {
        instance = this;
    }


    void Start()
    {
        spawnTimer = 0f;
        score = 0f;

        objectsToSpawn = new GameObject[] { wallPrefab, wallPrefab2, wallPrefab3 };
        StartCoroutine(SpawnObjects());
    }


    IEnumerator SpawnObjects()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, objectsToSpawn.Length);
            GameObject objectToSpawn = objectsToSpawn[randomIndex];

            GameObject obj = Instantiate(objectToSpawn);
            obj.transform.position = new Vector2(10, Random.Range(-1f, 1f));

            yield return new WaitForSeconds(spawnTerm);
        }
    }



    /*
    void Update()
    {
        spawnTimer += Time.deltaTime;

        score += Time.deltaTime;
        scoreLabel.text = ((int)score).ToString();

        if (spawnTimer > spawnTerm)
        {
            spawnTimer -= spawnTerm;

            GameObject obj = Instantiate(wallPrefab);
            obj.transform.position = new Vector2(10, Random.Range(-1.2f, 1.2f));
        }
    }
    */
}
