using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {
    public float jumpForce = 90f;

    private void OnCollisionEnter2D (Collision2D other) {
        if (other.gameObject.tag == "Player" && other.gameObject.name != "Cubo4") {
            other.gameObject.GetComponent<Rigidbody2D> ().velocity = (Vector2.up * jumpForce);
        }
    }
}