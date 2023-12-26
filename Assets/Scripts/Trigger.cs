using UnityEngine;

public class Trigger : MonoBehaviour, ITriggerVisitor
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ITriggerVisitable visitable))
        {
            visitable.Accept(this);
        }
    }

    public void Visit(Cube cube)
    {
        cube.PlayRotation();
        Print(cube);
    }

    public void Visit(Sphere sphere)
    {
        sphere.PlayPunchScale();
        Print(sphere);
    }

    public void Visit(Cylinder cylinder)
    {
        cylinder.PlayJump();
        Print(cylinder);
    }

    private void Print(MonoBehaviour mono) => print($"Visited {mono.name}!");
}
