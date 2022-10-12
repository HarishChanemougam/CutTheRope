using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] GameOver _gameOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.gameObject.tag == "candy")
        {
            Debug.Log("End");
            Destroy(collision.attachedRigidbody.gameObject);
            _gameOver.EndGame();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }
}
