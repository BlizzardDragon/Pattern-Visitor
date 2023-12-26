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
        Print(cube, Color.yellow);
    }

    public void Visit(Sphere sphere)
    {
        sphere.PlayPunchScale();
        Print(sphere, Color.red);
    }

    public void Visit(Cylinder cylinder)
    {
        cylinder.PlayJump();
        Print(cylinder, Color.blue);
    }

    private void Print(MonoBehaviour mono, Color color)
    {
        string formattedText = $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{mono.name}</color>";
        print($"Visited {formattedText}!");
    }
}
