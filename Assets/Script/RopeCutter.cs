using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.InputSystem;
using UnityEngine.iOS;
using UnityEngine.Android;
using TouchPhase = UnityEngine.TouchPhase;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.Touch;

public class RopeCutter : MonoBehaviour
{
    [SerializeField] private InputActionReference _input;
    [SerializeField] private LayerMask _RopeLayer;

    private Vector3 _oldPosition;
    private Vector3 _position;
    private float _width;
    private float _height;

    private Camera _mainCam;

    private void Awake()
    {
        _mainCam = Camera.main;

        _width = (float)Screen.width / 2f;
        _height = (float)Screen.height / 2f;

        _position = new Vector3(0f, 0f, 0f);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, _width, _height * 0.25f), "x = " + _position.x.ToString("f2") + ", y =" + _position.y.ToString("f2"));
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - _width) / _width;
                pos.y = (pos.y - _height) / _height;
                _position = new Vector3(-pos.x, pos.y, 0f);

                transform.position = _position;

                


                if (Input.touchCount == 2)
                {
                    touch = Input.GetTouch(1);

                    if (touch.phase == TouchPhase.Began)
                    {
                        transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);


                    }

                    if (touch.phase == TouchPhase.Ended)
                    {
                        transform.localScale = new Vector3(1f, 1f, 1f);
                    }
                }

            }

            else 
            {
                /* var ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                 var hit : RaycastHit;

                 if(Physics2D.Raycast(ray, hit))
                 {
                     if(hit.collider.tag =="rope")
                     {
                         Destroy(hit.transform.gameObject);
                     }
                 }*/

               /* Vector3 newPosition = _mainCam.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Linecast(_oldPosition, newPosition, _RopeLayer);

                if(hit.collider != null)
                {
                    Rope rope = hit.collider.transform.parent.GetComponent<Rope>();
                    if(!rope.IsRopeCut)
                    {
                        hit.collider.gameObject.SetActive(false);
                        rope.CutRope();
                    }
                }*/
            }
        }

        /*_oldPosition = newPosition;*/
    }
}
