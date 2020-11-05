using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActive : MonoBehaviour {
    private int player;
    public PlayerController[] players;

    private void Start () {
        for (int i = 0; i < players.Length; i++) {
            players[i].rb2D = GetComponent<Rigidbody2D> ();
            players[i].enabled = false;
        }
        players[0].enabled = true;
    }

    void Update () {
        if (Input.GetKeyDown (KeyCode.Q)) {
            for (int i = 0; i < players.Length; i++) {
                players[i].enabled = false;
                players[player].rb2D.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            }

            player++;

            if (player > players.Length - 1) {
                player = 0;
            }
            players[player].rb2D.constraints = RigidbodyConstraints2D.None;
            players[player].rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
            players[player].enabled = true;
        }
    }
}