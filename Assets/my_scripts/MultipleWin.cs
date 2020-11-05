using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultipleWin : MonoBehaviour {
    public int players;
    public string sceneName;
    public string playerName;
    public int victory = 0;

    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.name == playerName) {
            victory++;
        }
    }

    private void OnTriggerExit2D (Collider2D other) {
        if (other.gameObject.name == playerName) {
            victory--;
        }
    }

    private void Update () {
        if (victory == players) {
            SceneManager.LoadScene (sceneName);
        }
    }
}