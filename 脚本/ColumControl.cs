using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumControl : MonoBehaviour
{
    private float speed;
    public float shan;
    public float xia;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.5f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > shan)
        {
            transform.position = new Vector3(transform.position.x, shan, transform.position.z);
            speed = -speed;
        }
        if (transform.position.y < xia)
        {
            transform.position = new Vector3(transform.position.x, xia, transform.position.z);
            speed = -speed;
        }
        //柱子上下移动
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
    }
}
