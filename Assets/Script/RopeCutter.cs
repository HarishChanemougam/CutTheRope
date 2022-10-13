using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RopeCutter : MonoBehaviour
{
    [SerializeField] InputActionReference _Input;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            /*Touch touch = Input.GetTouch(0);
            if (touch.phase == UnityEngine.TouchPhase.Stationary)
            {

                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0)), Vector2.zero); ;

                if (hit.collider != null)
                {
                    if (hit.collider.tag == "Rope")
                    {
                        Destroy(hit.collider.gameObject);
                    }
                }

            }*/
        }
    }
}
