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
        if (Input.GetKeyDown(KeyCode.Escape))
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
                GetComponent<Player>().ResetAnimation();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                GameManager.GM.menuing = true;
                Menu.SetActive(true);
            }
        }
    }
}
