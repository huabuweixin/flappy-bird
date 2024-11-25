using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playercontrol : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public static bool life = true;//小鸟是否活着
    public AudioClip deadclip;

    private Rigidbody2D rb;//刚体
    private Animator anim;//动画控制器
    private GameObject gameover;//gameover图片
    private float time;
    private AudioSource aus;//音频源

    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gameover = GameObject.Find("Canvas/Image");
        aus = GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life == true)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);//赋予玩家水平移动向量
            if (Input.GetMouseButtonDown(0))//玩家触碰了屏幕
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);//赋予玩家垂直速度的向量
                aus.Play();
            }

        }
        else
        {
            time += Time.deltaTime;
            if (time >= 2)
            {
                danru.transforme("SampleScene");
            }
        }
        gameover.SetActive(!life);
    }
    //如果碰撞器碰撞到了某个物体
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (life)
        {
            Screenshanshuo.shanshuo();
            aus.clip = deadclip;
            aus.Play();
        }
        life = false;
        anim.SetBool("life", false);
    }
}
