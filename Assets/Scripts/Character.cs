﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//David Uriel Soto Alvarez 
//17551

public class Character : MonoBehaviour {
    public LayerMask layerMask; //Crea una variable para que aparezca en Unity de LayerMask
    public GameObject feet; //Crea una variable para que aparezca en Unity de feet
    Rigidbody2D rb2d;
    SpriteRenderer sr;
    Animator anim;
    private float speed = 5f;
    private float jumpForce = 250f;
    private bool facingRight = true;
 


	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
	

	void Update () {
        float move = Input.GetAxis("Horizontal");
        if (move != 0) {
            rb2d.transform.Translate(new Vector3(1, 0, 0) * move * speed * Time.deltaTime);
            facingRight = move > 0;
        }

        anim.SetFloat("Speed", Mathf.Abs(move));

        sr.flipX = !facingRight;

        if (Input.GetButtonDown("Jump")) {
            RaycastHit2D raycast = Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f, layerMask);
            if (raycast.collider != null)
                rb2d.AddForce(Vector2.up*jumpForce);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision) //Aqui persive si la nave tiene alguna colision con algun otro objeto 
    {
        if (collision.gameObject.name == "meta1") //Se verifica si la nave choca con un asteroide clonado
        {
            Application.LoadLevel("Dungeon2");
        }
        if (collision.gameObject.name == "Weight") //Se verifica si la nave choca con un asteroide clonado
        {
            Application.LoadLevel("Dungeon2");
        }
        if (collision.gameObject.name == "meta2") //Se verifica si la nave choca con un asteroide clonado
        {
            Application.LoadLevel("Dungeon3");
        }
        if (collision.gameObject.name == "meta3") //Se verifica si la nave choca con un asteroide clonado
        {
            Application.LoadLevel("Dungeon1");
        }
    }
}
