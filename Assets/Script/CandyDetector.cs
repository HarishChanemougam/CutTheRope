using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDetector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody.gameObject.tag =="candy")
        {
            Debug.Log("coucou");
            Destroy(collision.attachedRigidbody.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
