using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameButton : MonoBehaviour
{
    public void mainMenu()
    {
        CoreController.Instance().gameController.mainMenu();
    }
}
