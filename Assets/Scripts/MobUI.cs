using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class MobUI : MonoBehaviour
{
    public Slider healthBar;
    public Transform m_Camera;
    public TMP_Text mobName;

    private StatsController stats;

    void Awake() {
        stats = GetComponentInParent<StatsController>();
        mobName.text = "Baldur";
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(m_Camera.position);
        UpdateHealthBar();
    }



    void UpdateHealthBar() {
        if (healthBar) {
            healthBar.maxValue = stats.totalHealth;
            healthBar.value = stats.health;
        }
    }
}
