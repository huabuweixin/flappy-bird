using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class danru : MonoBehaviour
{
    public Texture img;//黑色图片
    public float speed;

    private static string game;
    private static  bool danchu = false;
    private static bool danr=false;
    private static float alpha=0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnGUI()
    {
        if (danchu)
        {
            alpha += speed * Time.deltaTime;
            if (alpha >= 1)
            {
                danr = true;
                danchu = false;
                SceneManager.LoadScene(game);
            }
        }
        if (danr)
        {
            alpha -= speed * Time.deltaTime;
            if (alpha <= 0)
            {
                danr = false;
            }
        }
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img);//绘制黑色图片
    }
    public static void transforme(string scene)
    {
        if (danr)
        {
            danr = false;
        }
        danchu=true;
        game = scene;
     }

}
