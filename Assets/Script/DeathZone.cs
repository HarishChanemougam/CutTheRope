using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class DeathZone : MonoBehaviour
{
    [SerializeField] GameOver _gameOver;
    [SerializeField] Animator _animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.gameObject.tag == "candy")
        {
            Debug.Log("End");
            Destroy(collision.attachedRigidbody.gameObject);
            _gameOver.EndGame();
           _animator.SetTrigger("CloseScreen");
          
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }
}
