using UnityEngine;

public class Sphere : MonoBehaviour, ITriggerVisitable
{
    public void Accept(ITriggerVisitor visitor) => visitor.Visit(this);
}
