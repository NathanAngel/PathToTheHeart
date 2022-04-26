using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 using UnityEngine.SceneManagement;

public class Scene_return : MonoBehaviour{
    
    private Button Back_B;
    // Start is called before the first frame update
    void Start()
    {
        Scene_init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Scene_init(){
        Back_B = GameObject.Find("Back_B").GetComponent<Button>();
        Back_B.onClick.AddListener(back);
    }
    public void back(){
        SceneManager.LoadScene(0);
    }
}
