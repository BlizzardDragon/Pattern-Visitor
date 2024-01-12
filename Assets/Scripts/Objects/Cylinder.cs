using DG.Tweening;
using UnityEngine;

public class Cylinder : MonoBehaviour, ITriggerVisitor
{
    [SerializeField] private GameObject _view;
    private Vector3 _startpLocalPosition;


    private void Start() => _startpLocalPosition = _view.transform.localPosition;

    void ITriggerVisitor.Visit(BlueTrigger blue) => PlayJump();
    void ITriggerVisitor.Visit(RedTrigger red) => _view.SetActive(false);
    void ITriggerVisitor.Visit(GreenTrigger green) => _view.SetActive(true);

    private void PlayJump() => _view.transform.DOLocalJump(_startpLocalPosition, 4, 1, 0.5f);
}
