﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour {
    public GameObject endgame;

	void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.tag == "Player")
        {
            endgame.SetActive(true);
            col.gameObject.SetActive(false);
        }
	}
}
