using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour

{
    public GameObject blueman2; 
    public float time; //宣告浮點數，名稱time


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; //時間增加
        if (time > 2.0f) //如果時間大於2.0(秒)
        {
            Vector3 pos = new Vector3(Random.Range(-17f, -10f), -3f, 0); //宣告位置pos，Random.Range
            Instantiate(blueman2, pos, transform.rotation);//產生敵人
            time = 0f; //時間歸零
        }
    }
}
