using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1f; 
    }
}
