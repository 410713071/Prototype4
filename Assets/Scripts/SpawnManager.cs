using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;//建立enemy prefab變數
    private float spawnRange = 9;//將void Start裡重複的9改成不被更改的變數

    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);//將spawnRange代入原本寫9的地方

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);//在此範圍產生隨機一個地方並給予其一個變數儲存位置

        Instantiate(enemyPrefab, randomPos, enemyPrefab.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
