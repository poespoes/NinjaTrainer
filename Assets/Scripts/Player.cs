using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public SpriteRenderer restartGoalImage;
    public SpriteRenderer gameoverImage;
    public bool submerge = false;
    public float movePerNSec = 1;
    public SpriteRenderer playerSprite;
    public float caughtTimer = 0;
    public float youGotCaughtIn = 0;
    public bool caughtCheck = false;
    public float restartStageTimer = 0;
    public float restartGoalTimer = 0;
    public SpriteRenderer subGoal;
    public SpriteRenderer subGoal_b;
    public SpriteRenderer subGoal_c;

    bool surfaced = false;
    bool underwater = false;
    bool canMove = true;
    bool isMoving = false;
    bool stopMoving = false;
    bool goalCheck = false;
    float moveTimer = 0;
    float goal4Counter = 0;
    bool goal4Check = false;
    
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("menu");
        }

        //Debug.Log(caughtTimer);
        if (restartStageTimer >= 0.8f) {
            gameoverImage.sortingOrder = 20;
            //SceneManager.LoadScene("end1");
            Debug.Log("got caught!");
        }
        if (restartGoalTimer >= 0.8f) {
            restartGoalImage.sortingOrder = 21;
            //SceneManager.LoadScene("end1");
            Debug.Log("got caught!");
        }

        //BG red and restart
        if (caughtTimer >= youGotCaughtIn) {
            restartStageTimer += Time.deltaTime;
            canMove = false;
        }


        //if (caughtTimer <= -1f) caughtTimer = -1;

        if (Input.GetKey(KeyCode.Space)) {
            caughtTimer -= Time.deltaTime;
            isMoving = true;
            playerSprite.sortingOrder = -1;
            underwater = true;
            surfaced = false;
    
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            Debug.Log("Space is UP!");
            playerSprite.sortingOrder = 5;
            underwater = false;
            surfaced = true;
        }
        if (surfaced == true) reSubmerge();

        if (isMoving == true) Move();


        if (stopMoving == false && canMove == false) {
            moveTimer += Time.deltaTime;
        }
        if (moveTimer >= movePerNSec) {
            canMove = true;
            moveTimer = 0;
        }
        if (goal4Counter == 3) {
            goal4Check = true;
        }
    }

    private void Move() {
        if (canMove == true) {
            transform.Translate(0, 0.2f, 0);
            canMove = false;
        }
    }

    private void reSubmerge() {
        caughtTimer += Time.deltaTime;
    }


    private void OnTriggerStay2D(Collider2D collision) {
        if (underwater == false && collision.gameObject.tag == "Goal") {
            Debug.Log("CLEAR!");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            SceneManager.LoadScene("cutscene1");
            //ADD STUFFS HERE!
        }
        if (underwater == false && collision.gameObject.tag == "Enemy") {
            Debug.Log("REKT! Enemy");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            caughtCheck = true;
            restartStageTimer += Time.deltaTime;
        }
        if (collision.gameObject.tag == "Enemy" && restartStageTimer >= 2) {
            SceneManager.LoadScene("tutorial");
        }
        if (underwater == false && collision.gameObject.tag == "Enemy1") {
            Debug.Log("REKT! Enemy1");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            caughtCheck = true;
            restartStageTimer += Time.deltaTime;
        }
        if (collision.gameObject.tag == "Enemy1" && restartStageTimer >= 2) {
            SceneManager.LoadScene("main");
        }
        if (underwater == false && collision.gameObject.tag == "Enemy2") {
            Debug.Log("REKT! Enemy1");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            caughtCheck = true;
            restartStageTimer += Time.deltaTime;
        }
        if (collision.gameObject.tag == "Enemy2" && restartStageTimer >= 2) {
            SceneManager.LoadScene("main2");
        }
        if (underwater == false && collision.gameObject.tag == "Enemy3") {
            Debug.Log("REKT! Enemy1");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            caughtCheck = true;
            restartStageTimer += Time.deltaTime;
        }
        if (collision.gameObject.tag == "Enemy3" && restartStageTimer >= 2) {
            SceneManager.LoadScene("main3");
        }
        if (underwater == false && collision.gameObject.tag == "Goal2") {
            Debug.Log("CLEAR!");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            SceneManager.LoadScene("cutscene2");
        }
        if (underwater == false && collision.gameObject.tag == "Goal3") {
            goalCheck = true;
            subGoal.sortingOrder = -5;
        }
        if (underwater == false && collision.gameObject.tag == "endGoal3" && goalCheck == true) {
            Debug.Log("CLEAR!");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            SceneManager.LoadScene("cutscene3");
        }
        if (underwater == false && collision.gameObject.tag == "endGoal3" && goalCheck == false) {
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            caughtCheck = true;
            restartStageTimer += Time.deltaTime;
        }
        if (collision.gameObject.tag == "endGoal3" && restartStageTimer >= 2) {
            SceneManager.LoadScene("cutscene3");
        }
            if (underwater == false && collision.gameObject.tag == "GoalTutorial") {
            Debug.Log("REKT!");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            SceneManager.LoadScene("cutscene0");
            //ADD STUFFS HERE!
        }
        if (underwater == false && collision.gameObject.tag == "Goal4") {
            goal4Counter += 1;
            subGoal.sortingOrder = -5;
        }
        if (underwater == false && collision.gameObject.tag == "Goal4b") {
            goal4Counter += 1;
            subGoal_b.sortingOrder = -5;
        }
        if (underwater == false && collision.gameObject.tag == "Goal4c") {
            goal4Counter += 1;
            subGoal_c.sortingOrder = -5;
        }
        if (underwater == false && collision.gameObject.tag == "endGoal4" && goal4Check == true) {
            Debug.Log("CLEAR!");
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            SceneManager.LoadScene("end3");
        }
        if (underwater == false && collision.gameObject.tag == "endGoal4" && goal4Check == false) {
            stopMoving = true;
            caughtTimer = 0;
            canMove = false;
            caughtCheck = true;
            restartGoalTimer += Time.deltaTime;
        }
    }
}
