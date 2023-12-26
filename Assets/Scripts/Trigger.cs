using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour, ITriggerVisitor
{

    private void OnTriggerEnter(Collider other)
    {

    }

    public void Visit(Cube cube) => Print(cube);
    public void Visit(Sphere sphere) => Print(sphere);
    public void Visit(Cylinder cylinder) => Print(cylinder);

    private void Print(object type) => print($"Visited {nameof(type)}!");
}
