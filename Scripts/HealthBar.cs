using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;    

    public void TakeDamage()
    {
        UpdateSliderValue(-10);
    }    

    public void TakeHeal()
    {
        UpdateSliderValue(10);
    }

    private void UpdateSliderValue(int stepValue)
    {
        _slider.DOValue(_slider.value + stepValue, 4);
    }
}
