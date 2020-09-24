using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            Die();
        
        if (Input.GetKeyDown(KeyCode.Tab))
            SceneManager.LoadScene("Menu");
    }

    private static void Die()
    {
        Application.Quit();
    }

    public void LoadPong()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadArkanoid()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadSidescroller()
    {
        SceneManager.LoadScene(3);
    }

    public static void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
