using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rope : MonoBehaviour
{
    [SerializeField] private GameObject _rope;
    [SerializeField] private int _ropeNumbers;
    [SerializeField] private Vector3 _ropeOffset;
    [SerializeField] private Rigidbody2D _candy;

    private HingeJoint2D _hook;
    private List<GameObject> _ropePrefab = new List<GameObject>();


    private void Awake()
    {
        _hook = GetComponent<HingeJoint2D>();
    }

    private void Start()
    {
        for (int i = 0; i < _ropeNumbers; i++)
        {
            GameObject currentRope = Instantiate(_rope, transform.position + _ropeOffset * i, Quaternion.identity, transform);

            if (i == 0)
            {
                _hook.connectedBody = currentRope.GetComponent<Rigidbody2D>();
            }

            else
            {
                _ropePrefab[_ropePrefab.Count - 1].GetComponent<HingeJoint2D>().connectedBody = currentRope.GetComponent<Rigidbody2D>();
            }

            if (i == _ropeNumbers - 1)
            {
                HingeJoint2D lastJoint = currentRope.GetComponent<HingeJoint2D>();
                lastJoint.connectedBody = _candy;
                lastJoint.connectedAnchor = Vector2.zero;
            }

            _ropePrefab.Add(currentRope);
        }
    }
}
