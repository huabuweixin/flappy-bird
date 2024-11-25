using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //用于监听鼠标按下物体
    private void OnMouseDown()
    {
        transform.localScale = transform.localScale * 0.8f;
    }
    //用于监听鼠标松开物体
    private void OnMouseUp()
    {
        transform.localScale = transform.localScale /0.8f;
        danru.transforme("game");
        Playercontrol.life = true;
        ScoreControl.score = 0;
    }
}
