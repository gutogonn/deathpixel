using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject canvas;

    private void FixedUpdate()
    {
        canvas = GameObject.Find("Canvas");
    }
    public void startGame()
    {
        SceneManager.LoadScene("Map1");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void justDied()
    {
        GameObject deadScreen = (GameObject)Instantiate(Resources.Load("Dead"));
        deadScreen.name = "Dead";
        deadScreen.transform.SetParent(canvas.transform);
        deadScreen.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        deadScreen.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        deadScreen.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }
}
