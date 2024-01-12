using DG.Tweening;
using UnityEngine;

public class Cube : MonoBehaviour, ITriggerVisitor
{
    [SerializeField] private GameObject _view;
    
    private const float Duration = 1f;
    private const int EndValueY = 360;


    void ITriggerVisitor.Visit(BlueTrigger blue)
    {
        PrintUtility.Print(blue.GetType().Name, Color.blue);
        PlayRotation();
    }

    void ITriggerVisitor.Visit(RedTrigger red)
    {
        PrintUtility.Print(red.GetType().Name, Color.red);
        _view.SetActive(false);
    }

    void ITriggerVisitor.Visit(GreenTrigger green)
    {
        PrintUtility.Print(green.GetType().Name, Color.green);
        _view.SetActive(true);
    }

    private void PlayRotation()
    {
        _view.transform.DOLocalRotate(Vector3.up * EndValueY, Duration, RotateMode.FastBeyond360);
    }
}
