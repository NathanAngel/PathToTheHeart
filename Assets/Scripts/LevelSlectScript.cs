using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSlectScript : MonoBehaviour
{
    void FixedUpdate(){
        if(Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene(Player.levelChoice);
        }
    }
}
