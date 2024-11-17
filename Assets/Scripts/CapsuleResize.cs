using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CapsuleResize : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.localScale += Vector3.one *_speed * Time.deltaTime;
    }
}
