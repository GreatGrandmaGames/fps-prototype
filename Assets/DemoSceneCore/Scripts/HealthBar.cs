using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Grandma;

public class HealthBar : MonoBehaviour
{
    private Slider slider;

    public Damageable playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = playerHealth.MaxHealth;
        slider.minValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = playerHealth.CurrentHealth;
    }
}
