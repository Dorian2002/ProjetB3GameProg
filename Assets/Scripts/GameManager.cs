using System;
using System.Collections;
using System.Collections.Generic;
using PlayerScripts;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public bool menuing;
    private bool gameover = false;
    public string arena;
    public string Equipment;
    public string Capacity1Name;
    public string Capacity2Name;
    public string Capacity3Name;
    public static GameManager GM;
    private List<Transform> spawnPoints;
    public GameObject Menu;
    private Wave currentWave;
    private int waveNbr;
    private List<GladiatorBT> ennemies;
    private GameObject arenaObject;
    public KeyCode jump {get; set;}
    public KeyCode forward {get; set;}
    public KeyCode backward {get; set;}
    public KeyCode left {get; set;}
    public KeyCode right {get; set;}
    public KeyCode capacity1 {get; set;}
    public KeyCode capacity2 {get; set;}
    public KeyCode capacity3 {get; set;}

    public GameObject ennemyPrefab;
    public Player player;

    void Awake()
    {
        arenaObject = Resources.Load<GameObject>("Prefabs/Arena1");
        Assert.IsNotNull(ennemyPrefab);
        ennemies = new List<GladiatorBT>();
        waveNbr = 0;
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

    public void LoadArena()
    {
        Instantiate(arenaObject);
        arenaObject = null;
    }

    public void GameOver()
    {
        
    }

    public bool IsGameOver()
    {
        return gameover;
    }

    public void GetSpawnPointsAndWave()
    {
        spawnPoints = new List<Transform>();
        spawnPoints.Add(GameObject.Find("spawnPoint1").transform);
        spawnPoints.Add(GameObject.Find("spawnPoint2").transform);
        spawnPoints.Add(GameObject.Find("spawnPoint3").transform);
        spawnPoints.Add(GameObject.Find("spawnPoint4").transform);
        newWave();
    }

    public void UpdateWave(GladiatorBT ennemy)
    {
        ennemies.Remove(ennemy);
        if (ennemies.Count <= 0)
        {
            newWave();
        }
    }
    
    public void ResetWave()
    {
        waveNbr = 0;
        foreach (var ennemy in ennemies)
        {
            try
            {
                ennemies.Remove(ennemy);
                DestroyImmediate(ennemy.gameObject);
            }
            catch {}
            if (ennemies.Count <= 0)
            {
                break;
            }
        }
        ennemies = new List<GladiatorBT>();
    }
    
    private void newWave()
    {
        ennemies = new List<GladiatorBT>();
        currentWave = new Wave(waveNbr);
        for (int i = 0; i < currentWave.GetNbr(); i++)
        {
            var go = Instantiate(ennemyPrefab);
            go.GetComponent<GladiatorBT>().SetStat(currentWave.GetStats());
            go.transform.position = spawnPoints[Random.Range(0, spawnPoints.Count)].position;
            ennemies.Add(go.GetComponent<GladiatorBT>());
        }
        waveNbr++;
    }

    public void AddPlayerXp()
    {
        player.GetStats().AddXp();
    }
}
