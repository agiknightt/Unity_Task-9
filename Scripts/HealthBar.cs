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
        ControlSlider(-10);
    }    

    public void TakeHeal()
    {
        ControlSlider(10);
    }

    private void ControlSlider(int stepValue)
    {
        _slider.DOValue(_slider.value + stepValue, 4);
    }
}
