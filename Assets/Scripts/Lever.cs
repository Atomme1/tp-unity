using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{

    public bool isOn = false;
    public GameObject LeverBaseTopGreen;
    public GameObject LeverBaseBottomRed;
    Animator animator;
    void Start() {
        animator = GetComponent<Animator>();
    }
    void Update(){
        
        //on va utiliser un raycast pour être sûr de cliquer sur le levier vert ou rouge 
        //donc on utilise 2 gameobject que je drag and drop dans Unity directement
        RaycastHit raycastHit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray,out raycastHit)){
            if(raycastHit.collider.gameObject == LeverBaseTopGreen)
            {
                click();
            }
            else if(raycastHit.collider.gameObject == LeverBaseBottomRed)
            {
                click();
            }
        }            
        
    }

    void click(){
        if (Input.GetMouseButtonDown(0) && isOn == false){
            isOn = true;
            Debug.Log("true");
            animator.SetBool("isOn", isOn);
        }
        else if (Input.GetMouseButtonDown(0) && isOn == true){
            isOn = false;
            Debug.Log("false");
            animator.SetBool("isOn", isOn);
        }
    }
}
