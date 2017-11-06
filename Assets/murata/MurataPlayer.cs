using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurataPlayer : MonoBehaviour {
	  //生成するオブジェクト
    public GameObject Ball;

    Transform pos;

	void Start ()
    {
        pos = GameObject.Find("GameObject").transform;
    }

    void Update()
    {
        //マウスクリック
        if (Input.GetMouseButton(0))
        {
            Instantiate(Ball,transform.position,pos.rotation);
        }
    }
}
