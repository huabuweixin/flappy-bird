using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yanxu : MonoBehaviour
{
    public GameObject shengcheng;
    public float len;
    private bool chufa=false;
    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chufa && Playercontrol.life)
        {
            time += Time.deltaTime;
            if (time > 3)
            {
                Destroy(transform.gameObject);//3秒后销毁自己
            }
        }
    }
    //当某个刚体碰撞至触发器时
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!chufa)
        {
            Instantiate(shengcheng, new Vector3(transform.position.x + len, transform.position.y, transform.position.z), transform.rotation);
            chufa = true;
        }
    }
}
