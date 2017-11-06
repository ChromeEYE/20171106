﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    bool m_xPlus = true;  // x 軸プラス方向に移動中
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (m_xPlus)
        {
            transform.position += new Vector3(2f * Time.deltaTime, 0f, 0f);
            if (transform.position.x >= 4)
                m_xPlus = false;
        }
        else
        {
            transform.position -= new Vector3(2f * Time.deltaTime, 0f, 0f);
            if (transform.position.x <= -4)
                m_xPlus = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}