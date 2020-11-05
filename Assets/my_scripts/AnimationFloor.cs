using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFloor : MonoBehaviour {
    public float speed;
    public Transform to;

    private void Start () {
        if (to != null) {
            to.parent = null;
        }
    }

    private void FixedUpdate () {
        if (to != null) {
            transform.position = Vector3.MoveTowards (transform.position, to.position, speed * Time.deltaTime);
        }
    }
}