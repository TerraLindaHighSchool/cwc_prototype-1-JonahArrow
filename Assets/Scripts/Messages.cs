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
        TextWriter.AddWriter_Static(messageText, "Hello World!", .1f, true);
    }

    private void Awake() 
    {
        messageText = transform.Find("messager").Find("Text").GetComponent<Text>();
    }
}
