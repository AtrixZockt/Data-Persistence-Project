using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiMainScene : MonoBehaviour
{
    public Text HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        if(Manager.Instance.HighScore == 0)
        {
            HighScoreText.text = "HighScore: Name: 0";
        } else
        {
            HighScoreText.text = "HighScore: " + Manager.Instance.HSPlayerName + ": " + Manager.Instance.HighScore;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
