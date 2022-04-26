using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D collides;
    private Vector2 velo;
    int spin;
    float initAngle;
    void Start()
    {
        spin = 100;
        gameObject.tag = "Enemy";
        collides = this.GetComponent<Rigidbody2D>();
        initAngle = transform.rotation.eulerAngles.z;
        findAngle();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        collides.MovePosition(collides.position + velo * Time.fixedDeltaTime);
        collides.MoveRotation(collides.rotation + spin * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D coll){
        if(!(coll.gameObject.tag == "Enemy")){
            LevelManageScript.totNumShots--;
            Destroy(gameObject);
        }
    }
    void findAngle(){
        if(initAngle == 180){
            velo = Vector2.down;
        }else if(initAngle == 90){
            velo = Vector2.left;
        }else if(initAngle == 270){
            velo = Vector2.right;
        }else if(initAngle >= 60 && initAngle < 61){
            velo = new Vector2(1,-1);
        }else if(initAngle >= 120 && initAngle < 121){
            velo = new Vector2(-1,-1);
        }else if(initAngle == 240){
            velo = new Vector2(-1,1);
        }else if(initAngle == 300){
            velo = new Vector2(1,1);
        }else if(initAngle >= 45 && initAngle < 46){
            velo = new Vector2(1,-1);
        }else if(initAngle >= 135 && initAngle < 136){
            velo = new Vector2(-1,-1);
        }else if(initAngle <= 225 && initAngle > 224){
            velo = new Vector2(-1,1);
        }else if(initAngle >= 315 && initAngle < 316){
            velo = new Vector2(1,1);
        }else{
            velo = Vector2.up;
        }
    }
}
