using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RibCage : MonoBehaviour
{
    public AudioSource WinSFX;
    private bool finished = false;
    private int wait = 0;
    void FixedUpdate(){
        if(finished){
            wait++;
        }
        if(wait >= 20){
          if(LevelManageScript.curLevel == 6){
                SceneManager.LoadScene(1);
                }else{
                SceneManager.LoadScene(++LevelManageScript.curLevel);
            }  
        }
    }
    void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag == "Player" && !finished){
            WinSFX.Play();
            finished = true;  
        }
    }
}
