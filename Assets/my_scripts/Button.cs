using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    [HideInInspector]
    public Rigidbody2D rb2D;
    public float verticalSpead = 20;
    // Start is called before the first frame update
    void Start () {
        rb2D = GetComponent<Rigidbody2D> ();
    }

    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "Player") {
            transform.Translate (0, verticalSpead, 0);
        }
    }
}