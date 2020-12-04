using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int score = 0;

    void Awake()
    {
        if (!instance)
            instance = this;
    }

    public void SetScore()
    {
        scoreText.text = "Score : " + GameObject.Find("GameManager").GetComponent<GameManager>().GetNumFellDownPins().ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        //AddScore(30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
