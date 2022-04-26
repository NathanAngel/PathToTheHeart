using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D shot;
    private Vector3 spawnAdjust;
    void Start()
    {
        if(transform.rotation.eulerAngles.z == 180){
            spawnAdjust = Vector3.down;
        }else if(transform.rotation.eulerAngles.z < 180 && transform.rotation.eulerAngles.z > 90){
            spawnAdjust = Vector3.left;
        }else if(transform.rotation.eulerAngles.z > 181){
            spawnAdjust = Vector3.right;
        }else{
            spawnAdjust = Vector3.up;
        }
        shoot();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(LevelManageScript.fire && LevelManageScript.totNumShots < LevelManageScript.shotsPer){
            shoot();
        }
    }
    void shoot(){
        LevelManageScript.totNumShots++;
        Instantiate(shot, transform.position + (spawnAdjust/2), transform.rotation);
    }
}
