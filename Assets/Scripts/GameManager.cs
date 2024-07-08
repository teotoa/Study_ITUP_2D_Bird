using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    static public GameManager instance;

    public GameObject wallPrefab;
    public float spawnTerm = 3;

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
    }


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
}
