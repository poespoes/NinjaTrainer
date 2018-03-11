using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject enemyFallPrefab;
    private float timer = 0;
    public float spawnInterval = 2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= spawnInterval) {
            GameObject newProjectileObj = Instantiate(enemyFallPrefab);
            newProjectileObj.transform.position = transform.position;
            timer = 0;
        }
    }
}
