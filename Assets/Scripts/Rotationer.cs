using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationer : VariableKeeper
{
    private void Update()
    {
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
    }
}
