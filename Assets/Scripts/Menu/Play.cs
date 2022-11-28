using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class Play : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("Arena1");
            GameManager.GM.LoadArena();
            GameManager.GM.ResetWave();
        } 
    }
}


