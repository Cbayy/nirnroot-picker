using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour{
    public GameObject textUI;
    public Text nirnrootTextUI;
    private int nirnrootCounter;
    int totalNirnroot;

    // Start is called before the first frame update
    void Start()
    {
        nirnrootCounter = 0;
        totalNirnroot = 1;
        nirnrootTextUI.text = "Nirnroot: " + nirnrootCounter + "/" + totalNirnroot;
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

    public void UpdateNirnrootCounter(){
        nirnrootTextUI.text = "Nirnroot: " + ++nirnrootCounter + "/" + totalNirnroot;
    }
}
