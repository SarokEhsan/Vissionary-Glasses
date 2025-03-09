using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandle : MonoBehaviour
{
    public Button confirmQuit;
    public Button cancelQuit;
    public GameObject canvas;
    public GameObject mainCamera;
    bool isSceneOnLoad = false;
    private void FixedUpdate()
    {
        if (isSceneOnLoad)
        {
            mainCamera.transform.Translate(0, 0, 1 * Time.deltaTime);
        }
    }
    public void LoadLevel()
    {
        isSceneOnLoad = true;
        StartCoroutine(LevelLoadRoutine());
        canvas.SetActive(false);
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

    IEnumerator LevelLoadRoutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(LevelNumber.Instance.level);
    }
}
