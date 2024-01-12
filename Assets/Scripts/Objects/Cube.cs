using DG.Tweening;
using UnityEngine;

public class Cube : MonoBehaviour, ITriggerVisitor
{
    [SerializeField] private GameObject _view;


    void ITriggerVisitor.Visit(BlueTrigger blue) => PlayRotation();
    void ITriggerVisitor.Visit(RedTrigger red) => _view.SetActive(false);
    void ITriggerVisitor.Visit(GreenTrigger green) => _view.SetActive(true);
    
    private void PlayRotation() => _view.transform.DOLocalRotate(Vector3.up * 360, 1f, RotateMode.FastBeyond360);
}
