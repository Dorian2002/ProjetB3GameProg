using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuing : MonoBehaviour
{
    private GameObject Menu;
    void Start()
    {
        Physics.autoSimulation = true;
        GameManager.GM.menuing = false;
        Menu = Instantiate(Resources.Load("Menu/InGameMenu") as GameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.GM.menuing)
            {
                Physics.autoSimulation = true;
                Menu.SetActive(false);
                GameManager.GM.menuing = false;
            }
            else
            {
                GameManager.GM.menuing = true;
                Physics.autoSimulation = false;
                Menu.SetActive(true);
            }
        }
    }
}
