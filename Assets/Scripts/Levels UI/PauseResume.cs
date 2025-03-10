using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseResume : MonoBehaviour
{
    public static PauseResume instance;
    public TextMeshProUGUI pauseOrResume;
    public GameObject backToMenuButton;
    public bool isGamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseOrResume.text = "Pause";
    }

    private void Awake()
    {
        instance = this;
    }
    public void PauseButtonFunc()
    {
        if (isGamePaused == false)
        {
            backToMenuButton.gameObject.SetActive(true);
            pauseOrResume.text = "Resume";
            isGamePaused = true;
        }
        else if (isGamePaused == true)
        {
            backToMenuButton.gameObject.SetActive(false);
            pauseOrResume.text = "Pause";
            isGamePaused = false;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
