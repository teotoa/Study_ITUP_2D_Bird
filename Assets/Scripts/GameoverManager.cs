using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameoverManager : MonoBehaviour
{

    public TextMeshProUGUI scoreLabel;

    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);

        scoreLabel.text = score.ToString();
    }


    void Update()
    {

    }

    public void PlayAgainPressed()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void QuitPressed()
    {
        Application.Quit();
    }
}
