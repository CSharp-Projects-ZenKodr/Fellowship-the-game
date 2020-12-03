using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public Button button;
    private SavesManager saves;
    private void Awake()
    {
        saves = FindObjectOfType<SavesManager>();
        if(saves != null)
        {
            button.interactable = true;
        }
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        if(saves != null)
        {
            Object.Destroy(saves);
        }
        SceneManager.LoadScene(1);
    }
    public void ContinueClick()
    {
        SceneManager.LoadScene(1);
    }
}
