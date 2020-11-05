using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float verticalSpead = 0.1f;
    public float jumpForce = 12f;
    int limitJump = 1;
    int totalJump;
    public Rigidbody2D rb2D;

    void Start () {
        rb2D = GetComponent<Rigidbody2D> ();
        totalJump = 0;
    }
    void FixedUpdate () {
        if (Input.GetKey (KeyCode.D)) {
            transform.Translate (verticalSpead, 0, 0);
        }
        if (Input.GetKey (KeyCode.A)) {
            transform.Translate (-verticalSpead, 0, 0);
        }
        if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W)) {
            if (limitJump > totalJump) {
                rb2D.AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
                totalJump++;
            }
        }
    }
    private void OnCollisionEnter2D (Collision2D other) {
        if (other.collider.tag == "floor" || other.collider.tag == "Player") {
            totalJump = 0;
        }
        if (other.collider.tag == "agua"){
            
        }
    }
}