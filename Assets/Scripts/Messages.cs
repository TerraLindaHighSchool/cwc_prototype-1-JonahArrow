 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages : MonoBehaviour
{
    public GameObject Message;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        messageText = transform.Find("messager").Find("Text").GetComponent<Text>();

    transform.Find("messager");
        {
            string[] messageArray = new string[4]
            {
            "Ah, hello there!",
            "You are a Player, am I correct?",
            "I am the creator of this game you see before you.",
            "Now, drive onward and enjoy the game!"
            };

            if (Message.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 5)
            {
                string message = messageArray[0];
                TextWriter.AddWriter_Static(messageText, message, .05f, true);
            }

            if (pause == 1005)
            {
                string message = messageArray[1];
                TextWriter.AddWriter_Static(messageText, message, .05f, true);
            }

            if (pause == 2005)
            {
                string message = messageArray[2];
                TextWriter.AddWriter_Static(messageText, message, .05f, true);
            }

            if (pause == 3005)
            {
                string message = messageArray[3];
                TextWriter.AddWriter_Static(messageText, message, .05f, true);
            }

            if (pause == 4005)
            {
                Message.gameObject.SetActive(false);
            }
        };
    }

    private void Awake() 
    {
        
    }
}
