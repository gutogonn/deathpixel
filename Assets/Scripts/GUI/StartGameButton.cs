using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    public void restart()
    {
        FactoryController.Instance().gameController.startGame();
    }
}
