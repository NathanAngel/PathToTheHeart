using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance {get; private set;}
    
    public void Awake(){
        if (Instance == null) { 
            Instance = this;
            DontDestroyOnLoad(this);
        } 
        else { 
            Destroy(this);
        } 
    }

    public static string charName;
    public static Color colorChoice;
    public static int levelChoice;
    // Start is called before the first frame update
    void Start()
    {
        charName = "";
        colorChoice = Color.white;
        levelChoice = 4;
    }
}
