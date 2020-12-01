    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLACEHOLDER : MonoBehaviour
{
    private SavesManager saves;
    private void Awake()
    {
        saves = FindObjectOfType<SavesManager>();
    }
    public void ToMenu()
    {
        saves.level++;
        SceneManager.LoadScene(1);
    }
}
