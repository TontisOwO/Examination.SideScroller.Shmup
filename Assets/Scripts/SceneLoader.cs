using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public PlayerData CurrentPlayerData = null;
    public void LoadScene(string aSceneName)
    {
        if (aSceneName == "CurrentLevel")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level " + CurrentPlayerData.CurrentLevel);
            CurrentPlayerData.HP = 3;
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(aSceneName);
        }
        if (aSceneName.StartsWith("Level"))
        {
            CurrentPlayerData.CurrentLevel = aSceneName[aSceneName.Length-1]-'0';
        }
    }
}
