using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour
{
    private float _speed = 20;
    private float growthRate = 0.2f;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
        transform.localScale += Vector3.one * growthRate * Time.deltaTime;
    }
}
