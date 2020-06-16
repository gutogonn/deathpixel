using UnityEngine;
using UnityEngine.UI;

public class TextWithShadow : MonoBehaviour
{
    private Text mainText;
    private GameObject shadow;
    private GameObject text;


    void Start()
    {
        mainText = gameObject.GetComponent<Text>();
        shadow = new GameObject();
        shadow.AddComponent<Text>();
        text = new GameObject();
        text.AddComponent<Text>();

        text.GetComponent<Text>().font = mainText.font;
        text.GetComponent<Text>().fontSize = mainText.fontSize;
        text.GetComponent<Text>().alignment = mainText.alignment;
        text.transform.position = new Vector3(mainText.gameObject.transform.position.x, mainText.gameObject.transform.position.y, mainText.gameObject.transform.position.z);
        text.GetComponent<RectTransform>().sizeDelta = new Vector2(mainText.gameObject.GetComponent<RectTransform>().rect.width, mainText.gameObject.GetComponent<RectTransform>().rect.height);
        text.name = "Text";

        shadow.transform.position = new Vector3(mainText.gameObject.transform.position.x + 4, mainText.gameObject.transform.position.y - 4, mainText.gameObject.transform.position.z);
        shadow.GetComponent<RectTransform>().sizeDelta = new Vector2(mainText.gameObject.GetComponent<RectTransform>().rect.width, mainText.gameObject.GetComponent<RectTransform>().rect.height);
        shadow.GetComponent<Text>().font = mainText.font;
        shadow.GetComponent<Text>().fontSize = mainText.fontSize;
        shadow.GetComponent<Text>().alignment = mainText.alignment;
        shadow.GetComponent<Text>().color = Color.black;
        shadow.name = "Shadow";

        shadow.transform.SetParent(gameObject.transform);
        text.transform.SetParent(gameObject.transform);
    }
    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = mainText.GetComponent<Text>().text;
        shadow.GetComponent<Text>().text = text.GetComponent<Text>().text;
    }
}
