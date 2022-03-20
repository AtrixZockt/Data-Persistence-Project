using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public string HSPlayerName;
    public int HighScore = 0;

    public string PlayerName;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHighScore(string name, int points)
    {
        HighScore = points;
        HSPlayerName = name;
    }

    [System.Serializable]
    class SaveData
    {
        public string HSPlayerName;
        public int HighScore;
    }

    public void SaveGame()
    {
        SaveData data = new SaveData();
        data.HighScore = HighScore;
        data.HSPlayerName = HSPlayerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighScore = data.HighScore;
            HSPlayerName = data.HSPlayerName;
        }
    }
}
