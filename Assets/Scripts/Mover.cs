using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : Changer
{
    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
