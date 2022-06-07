using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages19 : MonoBehaviour
{
    public GameObject Message19;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        messageText = transform.Find("messager19").Find("Text19").GetComponent<Text>();

        transform.Find("messager19");
        {
            string[] messageArray19 = new string[]
            {
            "WHAHAHA!",
            "I am free!",
            "Hm, who are you?",
            "I'll tell you what, I have a deal for you.",
            "Because you freed me, I will let you live.",
            "That's if you can defeat me in a old classic.",
            "Good luck, Player.",
            "You're going to need it."
            };

            if (Message19.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message19.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message19 = messageArray19[0];
                TextWriter.AddWriter_Static(messageText, message19, .05f, true);
            }

            if (pause == 201)
            {
                string message19 = messageArray19[1];
                TextWriter.AddWriter_Static(messageText, message19, .05f, true);
            }

            if (pause == 401)
            {
                string message19 = messageArray19[2];
                TextWriter.AddWriter_Static(messageText, message19, .05f, true);
            }

            if (pause == 601)
            {
                string message19 = messageArray19[3];
                TextWriter.AddWriter_Static(messageText, message19, .05f, true);
            }

            if (pause == 801)
            {
                string message19 = messageArray19[4];
                TextWriter.AddWriter_Static(messageText, message19, .05f, true);
            }

            if (pause == 1001)
            {
                string message19 = messageArray19[5];
                TextWriter.AddWriter_Static(messageText, message19, .05f, true);
            }

            if (pause == 1201)
            {
                string message19 = messageArray19[6];
                TextWriter.AddWriter_Static(messageText, message19, .05f, true);
            }

            if (pause == 1401)
            {
                string message19 = messageArray19[7];
                TextWriter.AddWriter_Static(messageText, message19, .05f, true);
            }

            if (pause == 1601)
            {
                Message19.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}