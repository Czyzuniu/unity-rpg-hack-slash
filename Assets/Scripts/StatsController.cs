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
    private Animator animator;


    public void Start() {
        health = totalHealth;
        mana = totalMana;
        animator = GetComponent<Animator>();
    }


    public void AddHealth(float health) {
        this.health += health;
    }

    public void MinusHealth(float health) {
        this.health -= health;
    }

    public void Die() {
        animator.SetTrigger("Dead");
    }
}
