using DG.Tweening;
using UnityEngine;

public class Cube : MonoBehaviour, ITriggerVisitor
{
    [SerializeField] private GameObject _view;


    void ITriggerVisitor.Visit(BlueTrigger blue)
    {
        PrintUtility.Print(nameof(blue), Color.blue);
        PlayRotation();
    }

    void ITriggerVisitor.Visit(RedTrigger red)
    {
        PrintUtility.Print(nameof(red), Color.red);
        _view.SetActive(false);
    }

    void ITriggerVisitor.Visit(GreenTrigger green)
    {
        PrintUtility.Print(nameof(green), Color.green);
        _view.SetActive(true);
    }

    private void PlayRotation() => _view.transform.DOLocalRotate(Vector3.up * 360, 1f, RotateMode.FastBeyond360);
}
