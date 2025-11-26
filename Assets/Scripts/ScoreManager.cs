using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    public int highScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        Debug.Log("Score"+ score);
        
    }

}
