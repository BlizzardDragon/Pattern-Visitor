using DG.Tweening;
using UnityEngine;

public class Cylinder : MonoBehaviour, ITriggerVisitable
{
    [SerializeField] private Transform _view;
    private Vector3 _startpLocalPosition;
    
    
    private void Start() => _startpLocalPosition = _view.localPosition;
    
    public void Accept(ITriggerVisitor visitor) => visitor.Visit(this);
    public void PlayJump() => _view.DOLocalJump(_startpLocalPosition, 4, 1, 0.5f);
}
