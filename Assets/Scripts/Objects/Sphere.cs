using DG.Tweening;
using UnityEngine;

public class Sphere : MonoBehaviour, ITriggerVisitor
{
    [SerializeField] private GameObject _view;


    void ITriggerVisitor.Visit(BlueTrigger blue)
    {
        PrintUtility.Print(nameof(blue), Color.blue);
        PlayPunchScale();
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

    public void PlayPunchScale() => _view.transform.DOPunchScale(Vector3.one * 1.5f, 1f, 4, 0);
}
