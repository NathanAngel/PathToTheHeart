using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D collide;
    private Vector2 fixedVelo;
    private SpriteRenderer HeartSprite;
    public AudioSource deathSFX;
    void Start()
    {
        collide = this.GetComponent<Rigidbody2D>();
        fixedVelo = new Vector2(17.5f,17.5f);
        HeartSprite = this.GetComponent<SpriteRenderer>();
        HeartSprite.color = Player.colorChoice;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        Movement();
    }
    void Movement(){
        if(Input.GetKey(KeyCode.W)){
            collide.MovePosition(collide.position + (fixedVelo * Vector2.up) * Time.fixedDeltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            collide.MovePosition(collide.position + (fixedVelo * Vector2.left) * Time.fixedDeltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            collide.MovePosition(collide.position + (fixedVelo * Vector2.down) * Time.fixedDeltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            collide.MovePosition(collide.position + (fixedVelo * Vector2.right) * Time.fixedDeltaTime);
        }        
    }
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "Enemy"){
            playDeath();
            transform.position = new Vector2(4.5f,1.5f);
            collide.velocity = Vector2.zero;
        }
    }
    void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag != "Finish"){
        playDeath();
        transform.position = new Vector2(4.5f,1.5f);
        collide.velocity = Vector2.zero;
        }
    }

    void playDeath(){
        deathSFX.Play();
    }
}   
