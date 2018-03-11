using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {
    float moveTimer = 0;
    bool canMove = true;
    public float movePerNSec = 2f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        moveTimer += Time.deltaTime;

        if (moveTimer >= movePerNSec) {
            canMove = true;
            moveTimer = 0;
        }
        if (canMove == true) {
            transform.Translate(0, -0.2f, 0);
            canMove = false;
        }

    }
}