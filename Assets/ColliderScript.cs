using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

        public HUD hud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other){
        print("EE");
        hud.OpenMessageText("");
    }

    private void OnTriggerExit(Collider other){
        print("OO");
        hud.CloseMessageText();
    }
}
