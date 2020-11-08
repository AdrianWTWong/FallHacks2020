using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public int maxEnemy;
    private int enemyCount = 0;
    private int xPos;
    private int yPos;

    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount < maxEnemy)
        {
            xPos = Random.Range(-9, 9);
            yPos = Random.Range(-9, 9);
            Instantiate(enemy, new Vector3(xPos, yPos, 18), Quaternion.identity);
            enemyCount += 1;
        }
    }
}

