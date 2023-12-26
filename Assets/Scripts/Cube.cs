using UnityEngine;

public class Cube : MonoBehaviour, ITriggerVisitable
{
    public void Accept(ITriggerVisitor visitor) => visitor.Visit(this);
}
