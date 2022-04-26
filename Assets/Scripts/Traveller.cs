using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traveller : MonoBehaviour
{
    private Rigidbody2D traveller;
    private Vector2 velo;
    private float spin;
    // Start is called before the first frame update
    void Start()
    {
        traveller = this.GetComponent<Rigidbody2D>();
        velo = new Vector2(0.0f,12.5f);
        spin = 100f;    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        traveller.MovePosition(traveller.position + (velo) * Time.fixedDeltaTime);
        traveller.MoveRotation(traveller.rotation + spin * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D coll){
        velo.y *= -1;
    }


}
