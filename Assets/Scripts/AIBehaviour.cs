using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehaviour : MonoBehaviour {
    public float wanderRadius;
    public float chaseSpeed;
    public float chaseDistance;
    public float lookoutTimer;
    public float baseSpeed = 1.5f;
    public float aggroRadius;
    public float timer;
    public float nextTimeToAttack;
    public float attackSpeed = 10f;
    private Animator animator;
    private Vector3 startingPosition;
    private NavMeshAgent agent;
    private bool isChasing;
    private bool isOnPath;
    private bool isLookout;
    private bool isEvade;
    private Vector3 pointOfChase;

    private bool isDead;
    private EntityMob entity;
    private GameObject target;
    private StatsController stats;

    void Awake() {
        stats = GetComponent<StatsController>();
        agent = GetComponent<NavMeshAgent>();
        timer = 0;
        animator = GetComponent<Animator>();
        startingPosition = transform.position;
        nextTimeToAttack = 0f;
        pointOfChase = Vector3.zero;
    }

    void Update() {
        animator.SetBool("IsWalking", !agent.isStopped);
        if (target && isChasing) {
            Chase();
        } else if (isEvade) {
            agent.SetDestination(startingPosition);
            if (agent.remainingDistance < 1.0f) {
                isEvade = false;
            }
        }
        else {
            Wander();
        }

        CheckDeath();
    }

    public void CheckDeath() {
        if (stats.health <= 0) {
            agent.isStopped = true;
            isDead = true;
            animator.SetTrigger("Dead");
            Destroy(gameObject, 5f);
        }
    }


    Vector3 PickNewWanderPoint() {
        return RandomNavSphere(startingPosition, wanderRadius, -1);
    }

    void Wander() {
        agent.speed = baseSpeed;
        if (!isOnPath && !isLookout) {
            Vector3 point = PickNewWanderPoint();
            agent.SetDestination(point);
            isOnPath = true;
        }

        if (agent.remainingDistance <= 1f) {
            isLookout = true;
            isOnPath = false;
        }

        if (isLookout) {
            agent.isStopped = true;
            timer += Time.deltaTime;
            if (timer > lookoutTimer) {
                agent.isStopped = false;
                timer = 0;
                isLookout = false;
                isOnPath = false;
            }
        }
        CheckForAttack();
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
        Vector3 randDirection = Random.insideUnitSphere * dist;
        randDirection += origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
        return navHit.position;
    }


    void CheckForAttack() {
        int layerMask = 1 << 9;
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, aggroRadius, layerMask);
        if (hitColliders.Length > 0) {
            target = hitColliders[0].gameObject;
            StartChase();
        }
    }

    private void StopChase() {
        agent.speed = baseSpeed;
        isChasing = false;
        target = null;
        pointOfChase = Vector3.zero;
        isEvade = true;
    }

    private void StartChase() {
        pointOfChase = transform.position;
        isChasing = true;
    }

    private void CheckForEvade() {
        float distanceFromStart = Vector3.Distance(pointOfChase, transform.position);
        if (distanceFromStart > chaseDistance) {
            StopChase();
        }
    }

    private void Chase() {
        agent.speed = chaseSpeed;
        Vector3 targetPos = target.GetComponent<Transform>().position;
        transform.LookAt(targetPos);
        agent.SetDestination(targetPos);
        float distance = Vector3.Distance(transform.position, targetPos);
        if (distance <= 2f) {
            agent.isStopped = true;
            if (CanAttack()) {
                Attack();
            } else {
            }
        } else {
            agent.isStopped = false;
        }

        CheckForEvade();
    }

    private void Attack() {
        animator.SetTrigger("Attack");
        nextTimeToAttack = Time.time + attackSpeed;
        float damageToDeal = (int) Random.Range(entity.level, entity.baseDmg * entity.level);
        if (target) {
            StatsController stats = target.GetComponent<StatsController>();
            if (stats) {
                stats.MinusHealth(damageToDeal);
            }
        }
    }

    private bool CanAttack() {
        return Time.time >= nextTimeToAttack;
    }

    private void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(startingPosition, aggroRadius);
    }
}
