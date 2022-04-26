using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D shot;
    void Start()
    {
        shoot6();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(LevelManageScript.fire && LevelManageScript.totNumShots < LevelManageScript.shotsPer){
            shoot6();
        }
    }

    private void shoot6(){
        transform.rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(shot, transform.position + (Vector3.up/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 60);
        Instantiate(shot, transform.position + (new Vector3(1,-1,0)/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 120);
        Instantiate(shot, transform.position + (new Vector3(-1,-1,0)/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 180);
        Instantiate(shot, transform.position + (Vector3.down/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 240);
        Instantiate(shot, transform.position + (new Vector3(-1,1,0)/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 300);
        Instantiate(shot, transform.position + (new Vector3(1,1,0)/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        LevelManageScript.totNumShots += 4;
    }
}

