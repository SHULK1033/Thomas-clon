using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinII : MonoBehaviour {

    private MultipleWin multipleWin;
    public string playerName;

    private void Start () {
        multipleWin = GameObject.Find ("Win").GetComponent<MultipleWin> ();
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.name == playerName) {
            multipleWin.victory++;
        }
    }

    private void OnTriggerExit2D (Collider2D other) {
        if (other.gameObject.name == playerName) {
            multipleWin.victory--;
        }
    }
}