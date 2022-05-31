 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages : MonoBehaviour
{
    public Text messageText;

    // Start is called before the first frame update
    void Start()
    {
        messageText.text = "Hello World";
    }

    private void Awake() 
    {
        messageText = transform.Find("messager").Find("Text").GetComponent<Text>();
    }
}
