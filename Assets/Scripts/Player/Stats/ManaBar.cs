using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    [Header("Reference to Mana")]
    // Player maximum Mana
    public float maxMana;
    // Player current Mana
    public float curMana;
    [Header("Reference to UI elements")]
    // Reference to Slider
    public Slider manaSlider;
    // Reference to Fill
    public Image manaFill;

    void Update()
    {
        manaSlider.value = Mathf.Clamp01(curMana / maxMana);
    }

    public void ExtraMana()
    {
        curMana = curMana + 10;
    }

    public void MinusMana()
    {
        curMana = curMana - 10;
    }
}