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

    public void Visit(Cube cube) => Print(cube);
    public void Visit(Sphere sphere) => Print(sphere);
    public void Visit(Cylinder cylinder) => Print(cylinder);

    private void Print(MonoBehaviour mono) => print($"Visited {mono.name}!");
}
