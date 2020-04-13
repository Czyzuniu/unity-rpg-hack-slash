using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName= "New Entity", menuName="Entity")]
public class Entity : ScriptableObject
{
    public new string name;
    public float attackSpeed;
    public float baseDmg;
    public float baseSpeed;
    public int level;
}
