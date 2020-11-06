using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultipleWin : MonoBehaviour {
    public int players;
    public string sceneName;
    //[HideInInspector]
    public int victory = 0;

    private void Update () {
        if (victory == players) {
            SceneManager.LoadScene (sceneName);
        }
    }
}