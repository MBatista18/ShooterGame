using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1.0f, 3.0f);
        InvokeRepeating("CreateEnemyTwo", 2.0f, 4.0f); // Adjust the delay for Enemy Two
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
    }

    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-8, 8), 6, 0), Quaternion.identity);
    }
}
In this script, I added a public GameObject enemyTwoPrefab; variable to hold the prefab for Enemy Two. The Start method now includes an InvokeRepeating call for creating Enemy Two at a specified interval (adjust the delay as needed). The CreateEnemyTwo method instantiates Enemy Two at a random position with a slightly lower Y coordinate to make it appear a bit downward.

Make sure to assign the Enemy Two prefab to the enemyTwoPrefab variable in the Unity Editor. Adjust the position and delay values according to your requirements.





