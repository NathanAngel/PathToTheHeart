using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
     private Button Credits_B;
     private Button Play_B;
     private Button CharCreate_B;
     private Button Exit_B;
     public static bool charMade = false;
     public static int difficulty = 3;
     public static Color colorPick = Color.white;

// Start is called before the first frame update
     void Start()
     {
          if(SceneManager.GetActiveScene().name == "MainMenu"){
               Init();
          }
     }

// Update is called once per frame
     void Update()
     {
     
     }

     private void Init(){
          Credits_B = GameObject.Find("Credits_B").GetComponent<Button>();
          Credits_B.onClick.AddListener(SceneSwap_Scene_Credits);
          Play_B = GameObject.Find("Play_B").GetComponent<Button>();
          Play_B.onClick.AddListener(SceneSwap_Scene_Play);
          CharCreate_B = GameObject.Find("CharCreate_B").GetComponent<Button>();
          CharCreate_B.onClick.AddListener(SceneSwap_Scene_Make_Character);
          Exit_B = GameObject.Find("Exit_B").GetComponent<Button>();
          Exit_B.onClick.AddListener(exit);
     }

     private void SceneSwap_Scene_Credits(){
          SceneManager.LoadScene(1);
     }

     private void SceneSwap_Scene_Play(){
          if(charMade){
               SceneManager.LoadScene(3);
          }
     }

     private void SceneSwap_Scene_Make_Character(){
          SceneManager.LoadScene(2);
     }

     private void exit(){
          Application.Quit();
     }
}
