using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D shot;
    private bool fourOrEight;
    void Start()
    {
        shoot4();
        fourOrEight = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(LevelManageScript.fire && LevelManageScript.totNumShots < LevelManageScript.shotsPer && fourOrEight){
            transform.rotation = Quaternion.Euler(0,0,0);
            shoot4();
            fourOrEight = false;
        }else if(LevelManageScript.fire && LevelManageScript.totNumShots < LevelManageScript.shotsPer){
            transform.rotation = Quaternion.Euler(0,0,45);
            shoot8();
            fourOrEight = true;
        }
    }

    private void shoot4(){
        transform.rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(shot, transform.position + (Vector3.up/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 90);
        Instantiate(shot, transform.position + (Vector3.left/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 180);
        Instantiate(shot, transform.position + (Vector3.down/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 270);
        Instantiate(shot, transform.position + (Vector3.right/2), transform.rotation);
        LevelManageScript.totNumShots += 4;
    }
    private void shoot8(){
        transform.rotation = Quaternion.Euler(0, 0, 45);
        Instantiate(shot, transform.position + (new Vector3(1,-1,0)/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 135);
        Instantiate(shot, transform.position + (new Vector3(-1,-1,0)/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 225);
        Instantiate(shot, transform.position + (new Vector3(-1,1,0)/2), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 315);
        Instantiate(shot, transform.position + (new Vector3(1,1,0)/2), transform.rotation);
        LevelManageScript.totNumShots += 4;
    }
}
