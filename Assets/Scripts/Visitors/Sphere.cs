using DG.Tweening;
using UnityEngine;

public class Sphere : MonoBehaviour, ITriggerVisitor
{
    [SerializeField] private GameObject _view;
    
    private const float PunchY = 1.5f;
    private const float Duration = 1f;
    private const int Vibrato = 4;
    private const int Elasticity = 0;


    void ITriggerVisitor.Visit(BlueTrigger blue)
    {
        PrintUtility.Print(blue.GetType().Name, Color.blue);
        PlayPunchScale();
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

    public void PlayPunchScale()
    {
        _view.transform.DOPunchScale(Vector3.one * PunchY, Duration, Vibrato, Elasticity);
    }
}
