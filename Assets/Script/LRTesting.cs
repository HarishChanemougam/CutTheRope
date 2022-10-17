using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.iOS;
using UnityEngine.Android;

public class LRTesting : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Rope _rope;

    private void Start()
    {
        _rope.SetUpLine(_points);
    }
}
