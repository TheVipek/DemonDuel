using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HumanHealthSlider : MonoBehaviour
{
    public Slider slider;
    void Start()
    {
        slider.maxValue = HumanSettings.health;
        slider.value = HumanSettings.health;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = HumanHealthController.actual_health;
    }
}
