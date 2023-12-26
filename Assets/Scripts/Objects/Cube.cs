using DG.Tweening;
using UnityEngine;

public class Cube : MonoBehaviour, ITriggerVisitable
{
    [SerializeField] private Transform _view;


    public void Accept(ITriggerVisitor visitor) => visitor.Visit(this);
    public void PlayRotation() => _view.DOLocalRotate(Vector3.up * 360, 1f, RotateMode.FastBeyond360);
}
