using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Resizer : Changer
{
    private void Update()
    {
        transform.localScale += Vector3.one *_speed * Time.deltaTime;
    }
}
