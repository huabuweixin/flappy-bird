using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{

    public Text ScoreText;
    // Start is called before the first frame update
    public static int score=0;
    private bool dowmchufa = false;
    private AudioSource audsou;
    void Start()
    {
        ScoreText = GameObject.Find("Canvas/Text").GetComponent<Text>();
        audsou= GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void OnGUI()
    {
        ScoreText.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!dowmchufa)
        {
            score++;
            audsou.Play();

        }
        dowmchufa = true;
    }
}
