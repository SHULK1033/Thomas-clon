using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
    public string sceneName;
    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene (sceneName);
        }
    }
    private void Update () {
        if (Input.GetKey (KeyCode.R)) {
            SceneManager.LoadScene (sceneName);
        }
    }
}