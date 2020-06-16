using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileButton : MonoBehaviour
{

    public void moveLeft()
    {
        FactoryController.Instance().mobileController.moveLeft();
    }

    public void moveRight()
    {
        FactoryController.Instance().mobileController.moveRight();
    }

    public void resetAxis()
    {
        FactoryController.Instance().mobileController.resetAxis();
    }

    public void jump()
    {
        FactoryController.Instance().mobileController.jump();
    }

}
