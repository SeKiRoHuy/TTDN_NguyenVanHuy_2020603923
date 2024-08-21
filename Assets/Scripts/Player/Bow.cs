﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour {

    public Transform bow;
    public Animator animator;
    public GameObject arrowPrefab;
    public GameObject sonido;

    // Update is called once per frame
    void Update() {
        //power dung ultimate skill
        //if (Input.GetKeyDown(KeyCode.C) && GetComponentInParent<Stats>().power == 4) {
        //    GetComponentInParent<Stats>().power = 0;
        //    Shoot();
        //}
        if (Input.GetKeyDown(KeyCode.C) )
        {
            Shoot();
        }

    }

    void Shoot() {
        // Animacion de disparar la fecha
        animator.SetTrigger("attackBow");
    }

    void ShootArrow() {
        // Dispara la flecha 
        Instantiate(arrowPrefab, bow.position, bow.rotation);

        //Sonido
        Instantiate(sonido);
    }

    public void AttackButton() {
            Shoot();
        }
    
}
