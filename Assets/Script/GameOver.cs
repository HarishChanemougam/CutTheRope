using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] float _stop;

    public void EndGame()
    {
        StartCoroutine(EndGameRoutine());
    }

    IEnumerator EndGameRoutine()
    {
        yield return new WaitForSeconds(_stop);

        SceneManager.LoadScene(0);
    }
}
