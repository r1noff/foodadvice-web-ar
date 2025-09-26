using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 to;
    [SerializeField] private float duration;
    [SerializeField] private Ease ease;
    
    [SerializeField] private Vector3 loopTo;
    [SerializeField] private float loopDuration;
    [SerializeField] private Ease loopEase;

    private void OnEnable()
    {
        DOTween.Sequence()
            .Append(
                transform .DOScale(to, duration).From(Vector3.zero) .SetEase(ease))
            .Append(transform.DOScale(loopTo, loopDuration).SetEase(loopEase).SetLoops(-1, LoopType.Yoyo))
            .Play();
    }

    private void OnDisable()
    {
        transform.DOKill();
    }
}
