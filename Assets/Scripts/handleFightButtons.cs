using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class handleFightButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame_Fight1()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayGame_Fight2()
    {
        SceneManager.LoadScene(3);
    }
    public void PlayGame_Fight3()
    {
        SceneManager.LoadScene(3);
    }
   
}
