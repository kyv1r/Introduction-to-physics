using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    [SerializeField] protected float _speed;

    protected void MoveForward()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }

    protected void Resize()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }

    protected void Rotation()
    {
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
    }
}
