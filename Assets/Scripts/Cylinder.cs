using UnityEngine;

public class Cylinder : MonoBehaviour, ITriggerVisitable
{
    public void Accept(ITriggerVisitor visitor) => visitor.Visit(this);
}
