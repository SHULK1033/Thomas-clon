using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour {
    Rigidbody2D fallFloor;

    private void Start () {
        fallFloor = GetComponent<Rigidbody2D> ();
    }
    private void OnCollisionExit2D (Collision2D other) {
        if (other.gameObject.tag == "Player") {
            fallFloor.bodyType = RigidbodyType2D.Dynamic;
            fallFloor.AddForce (new Vector2 (0, -0.2f), ForceMode2D.Impulse);
        }
    }
}