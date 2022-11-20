using System.Collections;
using System.Collections.Generic;
using PlayerScripts;
using UnityEngine;

public class InGameMenuing : MonoBehaviour
{
    private GameObject Menu;
    void Start()
    {
        GameManager.GM.menuing = false;
        Menu = Instantiate(Resources.Load("Menu/InGameMenu") as GameObject);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (GameManager.GM.IsGameOver())
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            GameManager.GM.menuing = true;
            Menu.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && !GameManager.GM.IsGameOver())
        {
            if (GameManager.GM.menuing)
            {
                
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Menu.SetActive(false);
                GameManager.GM.menuing = false;
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                GameManager.GM.menuing = true;
                Menu.SetActive(true);
            }
        }
    }
}
