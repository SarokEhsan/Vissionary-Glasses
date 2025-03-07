using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandle : MonoBehaviour
{
    public Button confirmQuit;
    public Button cancelQuit;

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelNumber.Instance.level);
    }

    public void QuitButton()
    {
        confirmQuit.gameObject.SetActive(true);
        cancelQuit.gameObject.SetActive(true);
    }
    public void ConfirmQuit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    public void CancelQuit()
    {
        confirmQuit.gameObject.SetActive(false);
        cancelQuit.gameObject.SetActive(false);
    }
}
