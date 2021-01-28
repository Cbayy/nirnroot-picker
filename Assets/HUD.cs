using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour{
    public GameObject textUI;
    public Text nirnrootTextUI;
    public Text questStartTextUI;

    private int nirnrootCounter;
    int totalNirnroot;

    // Start is called before the first frame update
    void Start()
    {
        nirnrootCounter = 0;
        totalNirnroot = 10;
        nirnrootTextUI.text = "Nirnroot: " + nirnrootCounter + "/" + totalNirnroot;
        StartCoroutine(startQuest("QUEST STARTED: NIRNROOT COLLECTOR"));
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

    IEnumerator startQuest(string text){
        questStartTextUI.text = text;
        questStartTextUI.enabled = true;
        yield return new WaitForSeconds(5);
        questStartTextUI.enabled = false;
    }
}
