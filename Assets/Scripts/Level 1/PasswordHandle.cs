using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasswordHandle : MonoBehaviour
{
    public TMP_InputField passwordInput;
    public TextMeshProUGUI winningText;
    public TextMeshProUGUI failText;

    public void GetInput()
    {
        if (passwordInput.text == "504972")
        {
            passwordInput.gameObject.SetActive(false);
            winningText.gameObject.SetActive(true);
            StartCoroutine(WinningRoutine());

        }
        else
        {
            passwordInput.gameObject.SetActive(false);
            PauseResume.instance.isGamePaused = false;
            failText.gameObject.SetActive(true);
            StartCoroutine(failTextRoutine());
        }
    }

    IEnumerator failTextRoutine()
    {
        yield return new WaitForSeconds(2.0f);
        failText.gameObject.SetActive(false);

    }
    IEnumerator WinningRoutine()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(0);
    }

    public void CancelSubmit()
    {
        PauseResume.instance.isGamePaused = false;
        passwordInput.gameObject.SetActive(false);
    }
}
