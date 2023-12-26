using DG.Tweening;
using UnityEngine;

public class Sphere : MonoBehaviour, ITriggerVisitable
{
    [SerializeField] private Transform _view;

    
    public void Accept(ITriggerVisitor visitor) => visitor.Visit(this);
    public void PlayPunchScale() => _view.DOPunchScale(Vector3.one * 1.5f, 1f, 4, 0);
}
