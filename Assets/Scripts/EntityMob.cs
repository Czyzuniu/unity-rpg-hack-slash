using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName= "New Mob", menuName="Entity/Mob")]
public class EntityMob : Entity
{
    public float aggroRadius;
    public float wanderRadius;
    public float chaseSpeed;
    public float chaseDistance;
    public float lookoutTimer;
}
