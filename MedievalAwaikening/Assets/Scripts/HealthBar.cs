using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxVie(int vie)
    {
        slider.maxValue = vie;
        slider.value = vie;
    }

    public void SetVie(int vie)
    {
        slider.value = vie;
    }
}
