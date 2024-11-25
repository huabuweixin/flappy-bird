using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screenshanshuo : MonoBehaviour
{
    public Texture img;//白色图片
    public float speed;
    // Start is called before the first frame update
    private static bool inwhite = false;
    private float alpha = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnGUI()
    {
        if (inwhite)
        {
            alpha += speed * Time.deltaTime;
            if (alpha > 1)
            {
                inwhite = false;
            }
        }
        else
        {
            if (alpha > 0){
                alpha -= speed * Time.deltaTime;
            }
        }
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.DrawTexture((new Rect(0, 0, Screen.width, Screen.height)), img);
        
    }
    public static void shanshuo()
    {
        inwhite = true;
    }
}
