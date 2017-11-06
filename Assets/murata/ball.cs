using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    //重力
    Rigidbody rb;

    //距離
    private float Max;

    //親
    Transform parent;

    // 弾丸の速度
    public float speed = 1000;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * speed);

        parent = GameObject.Find("Player").transform;

    }
    private void Update()
    {
        Max += Time.deltaTime;
        if(Max>10)
        {
            Destroy(gameObject);
        }
    }
}