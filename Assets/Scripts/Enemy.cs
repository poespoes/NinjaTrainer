using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float yPosition = 0.2f;
    public float hasMovedCounter = 1f;
    bool isUp = false;
    bool hasMovedUp = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hasMovedCounter >= 1 && isUp == true) {
            transform.Translate(0, -yPosition, 0);
            isUp = false;
            hasMovedUp = false;
        }
        if (hasMovedCounter <= 0 && hasMovedUp == false && isUp == false) {
            transform.Translate(0, yPosition, 0);
            isUp = true;
            hasMovedUp = true;
        }
        if (hasMovedUp == true) {
            hasMovedCounter += Time.deltaTime;
        }
        if (hasMovedUp == false) {
            hasMovedCounter -= Time.deltaTime;
        }
	}
}