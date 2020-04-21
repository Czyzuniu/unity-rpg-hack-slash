using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public PlayerInputActions inputActions;
    public GameObject weapon;
    public int comboStep = 0;
    public float comboTimeWindow = 1.5f;
    public LayerMask enemyLayers;

    private Animator animator;
    private float nextTimeToAttack = 0;
    public float maxCombo = 2;
    public float comboTimer;
    public bool isWeaponFlying;

    public bool inCombatStance;
    public GameObject hand;
    public GameObject back;
    private PlayerMovement playerMovement;
    public List<GameObject> colliders;
    public bool canAttack;
    private Vector3 throwDirection;

    void Awake() {
        inputActions = new PlayerInputActions();
        inputActions.PlayerControls.BattleStance.performed += ctx => ToggleBattleStance();
        inputActions.PlayerControls.StandardAttack.performed += ctx => StandardAttack();
        inputActions.PlayerControls.LightAttack.performed += ctx => LightAttack();
        inputActions.PlayerControls.HardAttack.performed += ctx => HardAttack();
    }

    void Start() {
        animator = GetComponent<Animator>();
        comboTimer = 0f;
        playerMovement = GetComponent<PlayerMovement>();
        //ToggleKinematicRigidBody(true);
        Cursor.lockState = CursorLockMode.Locked;
        ToggleWeaponColliders(false);
    }

    public void StandardAttack() {
        MakeAttack(0);
    }

    public void MakeAttack(int step) {
        if (inCombatStance && canAttack) {
            animator.SetTrigger("Attack");
            animator.SetInteger("Step", step);
        }
    }


    public void LightAttack() {
        MakeAttack(1);
    }

    public void HardAttack() {
        MakeAttack(2);
    }

    public void ToggleBattleStance() {
        inCombatStance = !inCombatStance;
        animator.SetBool("InBattleStance", inCombatStance);
        if (inCombatStance) {
            UnSheath();
            animator.SetTrigger("InCombat");
        } else {
            Sheath();
            animator.ResetTrigger("InCombat");
        }
    }

    public void UnSheath() {
        animator.SetTrigger("UnSheath");
        weapon.transform.SetParent(hand.transform);
        weapon.transform.position = hand.transform.position;
        weapon.transform.rotation = hand.transform.rotation;
        canAttack = true;
    }

    public void ToggleWeaponColliders(bool toggle) {
        foreach (GameObject collider in colliders) {
            collider.GetComponent<BoxCollider>().enabled = toggle;
        }
    }

    public void ToggleKinematicRigidBody(bool toggle) {
        Rigidbody rb = weapon.GetComponent<Rigidbody>();
        rb.isKinematic = toggle;
        rb.useGravity = !toggle;
    }

    public void Sheath() {
        animator.SetTrigger("Sheath");
        weapon.transform.SetParent(back.transform);
        weapon.transform.position = back.transform.position;
        weapon.transform.rotation = Quaternion.identity;
        canAttack = false;

    }

    public void Hit() {
        //RaycastHit[] hits = Physics.SphereCastAll(weapon.transform.position, 1.5f, weapon.transform.forward, 1.5f, enemyLayers);
        //foreach(RaycastHit hit in hits) {
        //    GameObject target = hit.collider.gameObject;
        //    StatsController statsController = target.GetComponent<StatsController>();
        //    if (statsController) {
        //        statsController.MinusHealth(25f);
        //    }
        //}
    }

    //combo stuff might reuse
    //comboTimer += Time.deltaTime;
    //    if (Input.GetMouseButtonDown(0) && canAttack) {
    //        animator.SetTrigger("Attack");

    //        if (comboStep > maxCombo) {
    //            comboStep = 0;
    //        }

    //        if (comboTimer <= comboTimeWindow) {
    //            comboStep++;
    //        }
    //        else {
    //            comboStep = 0;
    //            comboTimer = 0f;
    //        }
    //        animator.SetInteger("Step", comboStep);
    //        comboTimer = 0f;

    //    }

    // Update is called once per frame
    void Update()
    {


        //if (Input.GetMouseButtonDown(1)) {
        //    if (!isWeaponFlying) {
        //        animator.SetTrigger("Throw");
        //    }
        //    else {
        //        BringItBackBoy();
        //    }
        //}

    }

    private void ThrowingLogic() {
        if (Input.GetMouseButtonDown(1)) {
            animator.SetTrigger("PreThrow");
        }

        if (Input.GetMouseButtonUp(1)) {
            throwDirection = Camera.main.transform.forward;
            animator.ResetTrigger("PreThrow");
        }

        if (isWeaponFlying) {
            weapon.transform.Rotate(new Vector3(0, 0, -500) * Time.deltaTime);
            weapon.transform.position += throwDirection * Time.deltaTime * 1;
            //velocity.y += GRAVITY * Time.deltaTime;

        }
        else if (!isWeaponFlying && !weapon.transform.parent) {
            weapon.transform.Rotate(new Vector3(0, 0, -500) * Time.deltaTime);
            weapon.transform.position = Vector3.Lerp(weapon.transform.position, hand.transform.position, Time.deltaTime * 10);
            float distance = Vector3.Distance(weapon.transform.position, hand.transform.position);

            if (distance <= 1) {
                weapon.transform.parent = hand.transform;
                weapon.transform.position = hand.transform.position;
                weapon.transform.localRotation = Quaternion.identity;
            }
        }
    }

    private void BringItBackBoy() {
        isWeaponFlying = false;
        ToggleKinematicRigidBody(true);
    }

    public void ThrowWeapon() {
        weapon.transform.parent = null;
        isWeaponFlying = true;
    }

    private void OnEnable() {
        inputActions.Enable();
    }

    private void OnDisable() {
        inputActions.Disable();
    }
}
