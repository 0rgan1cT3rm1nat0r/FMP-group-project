using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public CanvasGroup OptionPanel;
    public string sceneToLoad;

    public void PlayGame()
    {
        SceneManager.LoadScene("TestScene2");
    }

    public void LoadCutScene2()
    {
        SceneManager.LoadScene("CutScene 1");

    }
    public void LoadCutScene()
    {
        SceneManager.LoadScene("CutScene");

    }
    public void Credits()
    {
        SceneManager.LoadScene("CreditsScene");

    }
    public void LoadCustomScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Option()
    {
        OptionPanel.alpha = 1;
        OptionPanel.blocksRaycasts = true;
    }

    public void Back()
    {
        OptionPanel.alpha = 0;
        OptionPanel.blocksRaycasts = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
