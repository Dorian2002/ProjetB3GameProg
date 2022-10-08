using System;
using System.Collections;
using System.Collections.Generic;
using PlayerScripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public  bool menuing;
    public string arena;
    public string Equipment;
    public string Capacity1Name;
    public string Capacity2Name;
    public string Capacity3Name;
    public static GameManager GM;
    public GameObject Menu;
    public KeyCode jump {get; set;}
    public KeyCode forward {get; set;}
    public KeyCode backward {get; set;}
    public KeyCode left {get; set;}
    public KeyCode right {get; set;}
    public KeyCode capacity1 {get; set;}
    public KeyCode capacity2 {get; set;}
    public KeyCode capacity3 {get; set;} 

    void Awake()
    {
        if(GM == null)
        {
            DontDestroyOnLoad(gameObject);
            GM = this;
        }	
        else if(GM != this)
        {
            Destroy(gameObject);
        }

        jump = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("jumpKey", "Space"));
        forward = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("forwardKey", "Z"));
        backward = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("backwardKey", "S"));
        left = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("leftKey", "Q"));
        right = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("rightKey", "D"));
        capacity1 = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("capacity1Key", "A"));
        capacity2 = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("capacity2Key", "E"));
        capacity3 = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("capacity3Key", "R"));
    }

    private IEnumerator LoadArena()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(arena);
        asyncOperation.allowSceneActivation = true;
        yield return null;
    }
}
