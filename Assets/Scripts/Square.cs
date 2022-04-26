using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D shot;
    void Start()
    {
        shoot4();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(LevelManageScript.fire && LevelManageScript.totNumShots < LevelManageScript.shotsPer){
            shoot4();
        }
    }

    private void shoot4(){
        transform.rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(shot, transform.position + (Vector3.up), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 90);
        Instantiate(shot, transform.position + (Vector3.left), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 180);
        Instantiate(shot, transform.position + (Vector3.down), transform.rotation);
        transform.rotation = Quaternion.Euler(0, 0, 270);
        Instantiate(shot, transform.position + (Vector3.right), transform.rotation);
        LevelManageScript.totNumShots += 4;
    }
}
