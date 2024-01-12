using UnityEngine;

public class BlueTrigger : MonoBehaviour, ITriggerVisitable
{
    private void OnTriggerEnter(Collider сollider)
    {
        if (сollider.TryGetComponent(out ITriggerVisitor visitor))
        {
            ((ITriggerVisitable)this).Accept(visitor);
        }
    }

    void ITriggerVisitable.Accept(ITriggerVisitor visitor) => visitor.Visit(this);
}
