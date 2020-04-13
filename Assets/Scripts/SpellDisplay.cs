using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellDisplay : MonoBehaviour
{
    public Spell spell;
    public Image art;
    // Start is called before the first frame update
    void Start()
    {
        art.sprite = spell.art;
    }
}
