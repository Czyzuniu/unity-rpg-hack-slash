using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Slider healthBar;
    public Slider manaBar;
    public TMP_Text healthStatusText;
    public TMP_Text manaStatusText;
    private StatsController stats;

    void Awake() {
        stats = GetComponent<StatsController>();
    }

    void Update() {
        healthBar.maxValue = stats.totalHealth;
        manaBar.maxValue = stats.totalMana;
        healthBar.value = stats.health;
        manaBar.value = stats.mana;
        healthStatusText.text = healthBar.value.ToString();
        manaStatusText.text = manaBar.value.ToString();
    }

}
