using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MakeChar_script : MonoBehaviour{ 
        
    private InputField CharName_IF;
    private Text CharName_Placehold_T;
    private Dropdown Color_DD;
    private Dropdown Difficulty_DD;
    private Button Back_B;
    private Image Heart_Img;
    
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        Heart_Img.color = Player.colorChoice;
        CharName_Placehold_T.text = Player.charName;
        Difficulty_DD.value = Player.levelChoice - 4;
    }

    private void Init(){
        CharName_IF = GameObject.Find("CharName_IF").GetComponent<InputField>();
        CharName_Placehold_T = GameObject.Find("CharName_IF").GetComponent<InputField>().placeholder.GetComponent<Text>();
        CharName_IF.onEndEdit.AddListener(IF_input_CharName);
        Color_DD = GameObject.Find("Color_DD").GetComponent<Dropdown>();
        Color_DD.onValueChanged.AddListener(ColorPick_DD);
        Difficulty_DD = GameObject.Find("Difficulty_DD").GetComponent<Dropdown>();
        Difficulty_DD.onValueChanged.AddListener(DifficultyPick_DD);
        Back_B = GameObject.Find("Back_B").GetComponent<Button>();
        Heart_Img = GameObject.Find("Heart_Img").GetComponent<Image>();
        Back_B.onClick.AddListener(back);
    }

    
    
    private void IF_input_CharName(string inText){
        CharName_Placehold_T.text = inText;
        Player.charName = inText;
        GameManager.charMade = true;
    }
    
    public void ColorPick_DD(int val){
        if(Color_DD.value == 0){
            Player.colorChoice = Color.white;
        }else if(Color_DD.value == 1){
            Player.colorChoice = Color.red;
        }else if(Color_DD.value == 2){
            Player.colorChoice = new Color(.5f,0,1,1);
        }else{
            Player.colorChoice = new Color(1,.5f,0,1);
        }
        Heart_Img.color = Player.colorChoice;
        GameManager.colorPick = Player.colorChoice;
    }
    
    public void DifficultyPick_DD(int val){
        GameManager.difficulty = Difficulty_DD.value + 4;
        Player.levelChoice = Difficulty_DD.value + 4;
    }
    
    public void back(){
        SceneManager.LoadScene(0);
    }
}