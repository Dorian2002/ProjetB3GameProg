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
            SceneManager.LoadSceneAsync("Arena1");
            GameManager.GM.ResetWave();
        } 
    }
}


