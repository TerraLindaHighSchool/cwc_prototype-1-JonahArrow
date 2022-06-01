using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages1 : MonoBehaviour
{
    public GameObject Message1;
    public Text messageText;
    public bool textComplete = true;
    public int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager1").Find("Text").GetComponent<Text>();

        pause++;

        transform.Find("messager1");
        {
            string[] messageArray1 = new string[]
            {
            "Bogos"
            };

            if (pause == 5)
            {
                string message1 = messageArray1[0];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 1005)
            {
                string message1 = messageArray1[1];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 2005)
            {
                string message1 = messageArray1[2];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 3005)
            {
                string message1 = messageArray1[3];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 4005)
            {
                Message1.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}
