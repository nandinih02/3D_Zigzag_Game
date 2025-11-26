using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public TMP_Text taptext;
    public TMP_Text highScore1;
    public TMP_Text highScore2;
    public Button reset;
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
        gameOverPanel.SetActive(false);
        zigzagPanel.SetActive(true);
    }

    public void GameStart()
    {
        taptext.enabled = false;
        zigzagPanel.GetComponent<Animator>().Play("panelUp");

    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
