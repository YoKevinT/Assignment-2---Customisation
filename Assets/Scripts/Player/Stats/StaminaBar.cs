using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    [Header("Reference to Stamina")]
    // Player maximum Stamina
    public float maxStamina;
    // Player current Stamina
    public float curStamina;
    [Header("Reference to UI elements")]
    // Reference to Slider
    public Slider staminaSlider;
    // Reference to Fill
    public Image staminaFill;

    void Update()
    {
        staminaSlider.value = Mathf.Clamp01(curStamina / maxStamina);
    }

    public void ExtraStamina()
    {
        curStamina = curStamina + 10;
    }

    public void MinusStamina()
    {
        curStamina = curStamina - 10;
    }
}