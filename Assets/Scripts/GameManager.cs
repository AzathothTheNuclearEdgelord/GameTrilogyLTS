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

    public static void Die()
    {
        Application.Quit();
    }

    public static void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
