using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour{
    public GameObject textUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMessageText(string text){
        textUI.SetActive(true);
    }

    public void CloseMessageText(){
        textUI.SetActive(false);
    }
}
