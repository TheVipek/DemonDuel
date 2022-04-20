using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DemonHealthSlider : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = DemonSettings.health;
        slider.value = DemonSettings.health;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = DemonHealthController.actual_health;
    }
}
