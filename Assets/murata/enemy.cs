using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    Transform player;

    Vector3 vec;
    float mag;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        vec = player.position - transform.position;
        mag = vec.magnitude;
        if (mag < 25)
        {
            transform.Translate(new Vector3(-vec.x, 0, -vec.z).normalized);
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