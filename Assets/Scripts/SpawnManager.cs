using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;//建立enemy prefab變數


    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(-9, 9);
        float spawnPosZ = Random.Range(-9, 9);//經過測量發現平台大小大約落在9x9的範圍中

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);//在此範圍產生隨機一個地方並給予其一個變數儲存位置

        Instantiate(enemyPrefab, randomPos, enemyPrefab.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
