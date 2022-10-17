using UnityEngine;
using NaughtyAttributes;
using UnityEngine.iOS;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
using System;

public class LevelSelector : MonoBehaviour
{

   
    public void Select(String levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
