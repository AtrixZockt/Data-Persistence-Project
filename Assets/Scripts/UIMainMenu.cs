using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;
    public Text Username_field;

    // Start is called before the first frame update
    void Start()
    {
        if (Manager.Instance.HighScore == 0)
        {
            HighScoreText.text = "HighScore: Name: 0";
        }
        else
        {
            HighScoreText.text = "HighScore: " + Manager.Instance.HSPlayerName + ": " + Manager.Instance.HighScore;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Manager.Instance.PlayerName = Username_field.text.ToString();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
