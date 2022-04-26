using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class LevelManageScript : MonoBehaviour
{
    public static TilemapCollider2D mapbounds;
    public static int shotsPer;
    public static int totNumShots;
    public static int ticker;
    public static int shotspeed;
    public static bool fire;
    public AudioSource shootsfx;
    public static int curLevel;
    private Scene curScene;
    private int totalEnemies;
    
    // Start is called before the first frame update
    void Start()
    {
        curScene = SceneManager.GetActiveScene();
        curLevel = curScene.buildIndex;
        totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        mapbounds = GameObject.Find("Tilemap").GetComponent<TilemapCollider2D>();
        shotsPer = 8 * totalEnemies;
        totNumShots = 0;
        ticker = 0;
        shotspeed = 200;
        fire = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ticker++;
        if (ticker >= shotspeed){
            shootsfx.Play();
            ticker = 0;
            fire = true;
        }else{
            fire = false;
        }
        if(Input.GetKey(KeyCode.Escape)){
            toMain();
        }

      
    }
    
    void toMain(){
        SceneManager.LoadScene(0);
    }

}
