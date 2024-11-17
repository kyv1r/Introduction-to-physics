using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Resizer : VariableKeeper
{
    private void Update()
    {
        transform.localScale += Vector3.one *_speed * Time.deltaTime;
    }
}
