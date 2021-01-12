using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

    public HUD hud;
    //GameObject pickup = null;
    bool pickup = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pickup == true && Input.GetKeyDown(KeyCode.E)){
            hud.CloseMessageText();
            print(this.name);
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter(Collider other){
        pickup = true;
        hud.OpenMessageText("");
    }

    private void OnTriggerExit(Collider other){
        pickup = false;
        hud.CloseMessageText();
    }
}
