using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject diamond;
    public static GameManager instance;
    public bool gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(instance==null)
        {
            instance=this;
        }
    }

    void Start()
    {
        gameOver = false;
    }
    public void StartGame()
    {
        UIManager.instance.GameStart();
        PlatformSpawner.instance.SpawnStart();
    }

    public void GameOver()
    {
        UIManager.instance.GameOver();
        gameOver=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(diamond);
    }
}
