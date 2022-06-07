using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages15 : MonoBehaviour
{
    public GameObject Message15;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager15").Find("Text15").GetComponent<Text>();

        transform.Find("messager15");
        {
            string[] messageArray15 = new string[]
            {
            "Well done, you completed the race course.",
            "Anyways, I did some research into the button that appeared in my game.",
            "Someone deliberately put that button in my game without me knowing.",
            "Alright time to bring you back.",
            "What the-"
            };

            if (Message15.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message15.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message15 = messageArray15[0];
                TextWriter.AddWriter_Static(messageText, message15, .05f, true);
            }

            if (pause == 201)
            {
                string message15 = messageArray15[1];
                TextWriter.AddWriter_Static(messageText, message15, .05f, true);
            }

            if (pause == 401)
            {
                string message15 = messageArray15[2];
                TextWriter.AddWriter_Static(messageText, message15, .05f, true);
            }

            if (pause == 601)
            {
                string message15 = messageArray15[3];
                TextWriter.AddWriter_Static(messageText, message15, .05f, true);
            }

            if (pause == 801)
            {
                string message15 = messageArray15[4];
                TextWriter.AddWriter_Static(messageText, message15, .05f, true);
            }

            if (pause == 1001)
            {
                Message15.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}