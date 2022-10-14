using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class Sensor : MonoBehaviour
{
    [SerializeField] Animator _animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.gameObject.tag == "candy")
        {
            _animator.SetTrigger("OpeningMouthanim");

            Debug.Log("CandyDetected");
        }

        else
        {
            _animator.SetTrigger("Idel");
            Debug.Log("NoCandy");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
