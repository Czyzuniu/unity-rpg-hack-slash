using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsController : MonoBehaviour
{

    public float baseSpeed;
    public float health;
    public float mana;
    public float totalHealth;
    public float totalMana;
    public float armor;
    private bool isDead;


    public void Start() {
        health = totalHealth;
        mana = totalMana;
    }


    public void AddHealth(float health) {
        this.health += health;
    }

    public void MinusHealth(float health) {
        this.health -= health;
    }
}
