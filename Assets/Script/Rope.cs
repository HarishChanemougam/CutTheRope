using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.InputSystem;


public class Rope : MonoBehaviour
{
    [SerializeField] public GameObject _rope;
    [SerializeField] private int _ropeNumbers;
    [SerializeField] private Vector3 _ropeOffset;
    [SerializeField] private Rigidbody2D _candy;

    bool _ropeCut;
    bool _isRopeCut;

    LineRenderer _lineRenderer;
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

   

    private void Update()
    {
        _lineRenderer.positionCount = _ropeNumbers + 1;
        _lineRenderer.SetPosition(0, transform.position);
        int firestLine = 0;
        for (int i = 0; i < _ropeNumbers; i++)
        {
            if (_ropePrefab[i] != null && _ropePrefab[i].activeSelf)
            {
                /*_lineRenderer.SetPosition(i+1, _ropePrefab[i], transform.position);*/
            }

            else
            {
                _lineRenderer.positionCount = i + 1;
                break;
            }
        }

        if(_ropeCut)
        {
        _lineRenderer.positionCount = _ropeNumbers - firestLine - 1;
        for(int j = 0; j < _ropeNumbers - firestLine; j++)
        {
            _lineRenderer.SetPosition(j, _ropePrefab[firestLine + 1 + j].transform.position);
        }
        }
    }

    public void CutRope()
    {
        _isRopeCut = true;
    }

}
