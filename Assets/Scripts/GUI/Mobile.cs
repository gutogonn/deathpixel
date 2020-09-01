using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mobile : MonoBehaviour
{

    public Button leftButton;
    public Button rightButton;
    public Button jumpButton;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        jumpButton.onClick.AddListener(jump);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void left(){
        if(Moviment.Instance().move_input < 1){
            Moviment.Instance().move_input += 70f * Time.deltaTime;
        }
    }
    public void right(){
        if(Moviment.Instance().move_input > -1){
            Moviment.Instance().move_input -= 70f * Time.deltaTime;
        }
    }

    public void stop(){
         Moviment.Instance().move_input = 0;
    }

    private void jump(){
        Moviment.Instance().jump();
    }
}
