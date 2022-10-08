using System.Collections;
using System.Collections.Generic;
using PlayerScripts;
using UnityEngine;

public class InGameMenuing : MonoBehaviour
{
    private GameObject Menu;
    void Start()
    {
        Physics.autoSimulation = true;
        GameManager.GM.menuing = false;
        Menu = Instantiate(Resources.Load("Menu/InGameMenu") as GameObject);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.GM.menuing)
            {
                
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Physics.autoSimulation = true;
                Menu.SetActive(false);
                GameManager.GM.menuing = false;
            }
            else
            {
                GetComponent<Player>().ResetAnimation();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                GameManager.GM.menuing = true;
                Physics.autoSimulation = false;
                Menu.SetActive(true);
            }
        }
    }
}
