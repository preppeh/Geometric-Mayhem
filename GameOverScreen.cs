using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public Text pointsText;
    public PauseMenu pause;

    public void Setup(int score)
    {
        pause.Pause();
        gameObject.SetActive(true);
        pointsText.text = "Score: " + score.ToString() + " Points";
    }

    public void restartButton()
    {
        pause.Resume();
        SceneManager.LoadScene("SampleScene");
    }

    public void menuButton()
    {
        pause.Resume();
        SceneManager.LoadScene("Start Menu");
    }
}