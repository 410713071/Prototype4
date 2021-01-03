using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;//建立enemy prefab變數


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, new Vector3(0, 0, 6), enemyPrefab.transform.rotation);//將敵人建立在指定的XYZ上
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
