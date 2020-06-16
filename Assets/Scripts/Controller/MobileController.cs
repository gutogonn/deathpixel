using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
{
    public float axis;
    public Moviment playerMove;
    public GameObject canvas;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (FactoryController.Instance().mobileController == null) return;
        canvas = GameObject.Find("Canvas");
        playerMove = FactoryController.Instance().playerController.playerGO;
        if (playerMove == null) return;

        GameObject mobile = (GameObject)Instantiate(Resources.Load("Dead"));
        mobile.name = "Mobile";
        mobile.transform.SetParent(canvas.transform);
        mobile.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        mobile.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        mobile.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        
        playerMove.mobile_input = axis;
    }

    public void jump()
    {
        playerMove.jump();
    }

    public void resetAxis()
    {
        axis = 0;
    }

    public void moveRight()
    {
        if (axis > 1) {
            axis = 1;
        }
        axis += 1f;
    }

    public void moveLeft()
    {
        if (axis < -1)
        {
            axis = -1;
        }
        axis -= 1f;
    }
}
