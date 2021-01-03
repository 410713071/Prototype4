using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;//給予速度變數一個數值
    private Rigidbody enemyRb;//建立enemy實體變數
    private GameObject player;//建立player物件變數

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();//拿取enemy實體變數數據
        player = GameObject.Find("player");//在所有的GameObject中尋找player，並拿去player的數據
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
