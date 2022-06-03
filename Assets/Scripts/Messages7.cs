using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages7 : MonoBehaviour
{
    public GameObject Message7;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager7").Find("Text7").GetComponent<Text>();

        transform.Find("messager7");
        {
            string[] messageArray7 = new string[4]
            {
            "Alright that's it.",
            "If you like falling so much, then what am I to stop you.",
            "Goodbye, Player, enjoy the abyss.",
            "Have fun not playing my game."
            };

            if (Message7.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message7.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 7)
            {
                string message7 = messageArray7[0];
                TextWriter.AddWriter_Static(messageText, message7, .05f, true);
            }

            if (pause == 756)
            {
                string message7 = messageArray7[1];
                TextWriter.AddWriter_Static(messageText, message7, .05f, true);
            }

            if (pause == 1756)
            {
                string message7 = messageArray7[2];
                TextWriter.AddWriter_Static(messageText, message7, .05f, true);
            }

            if (pause == 2756)
            {
                string message7 = messageArray7[3];
                TextWriter.AddWriter_Static(messageText, message7, .05f, true);
            }

            if (pause >= 3754)
            {
                Message7.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}