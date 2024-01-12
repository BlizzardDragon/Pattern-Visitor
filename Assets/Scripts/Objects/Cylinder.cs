using DG.Tweening;
using UnityEngine;

public class Cylinder : MonoBehaviour, ITriggerVisitor
{
    [SerializeField] private GameObject _view;
    
    private Vector3 _startpLocalPosition;

    private const int JumpPower = 4;
    private const int NumJumps = 1;
    private const float Duration = 0.5f;


    private void Start() => _startpLocalPosition = _view.transform.localPosition;

    void ITriggerVisitor.Visit(BlueTrigger blue)
    {
        PrintUtility.Print(nameof(blue), Color.blue);
        PlayJump();
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

    private void PlayJump() => _view.transform.DOLocalJump(_startpLocalPosition, JumpPower, NumJumps, Duration);
}
