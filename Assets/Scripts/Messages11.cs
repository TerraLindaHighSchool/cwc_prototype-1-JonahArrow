using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages11 : MonoBehaviour
{
    public GameObject Message11;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager11").Find("Text11").GetComponent<Text>();

        transform.Find("messager11");
        {
            string[] messageArray11 = new string[7]
            {
            "What just happened?",
            "You pressed it, didn't you?",
            "Oh great, we're stuck in one of my old test worlds.",
            "This is so embarrassing.",
            "There's no textures, no environment, no escape.",
            "Well I suppose we can make what fun we can out of this.",
            "Do a lap around the track."
            };

            if (Message11.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message11.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 4)
            {
                string message11 = messageArray11[0];
                TextWriter.AddWriter_Static(messageText, message11, .05f, true);
            }

            if (pause == 754)
            {
                string message11 = messageArray11[1];
                TextWriter.AddWriter_Static(messageText, message11, .05f, true);
            }

            if (pause == 1504)
            {
                string message11 = messageArray11[2];
                TextWriter.AddWriter_Static(messageText, message11, .05f, true);
            }

            if (pause == 3004)
            {
                string message11 = messageArray11[3];
                TextWriter.AddWriter_Static(messageText, message11, .05f, true);
            }

            if (pause == 3754)
            {
                string message11 = messageArray11[4];
                TextWriter.AddWriter_Static(messageText, message11, .05f, true);
            }

            if (pause == 5254)
            {
                string message11 = messageArray11[5];
                TextWriter.AddWriter_Static(messageText, message11, .05f, true);
            }

            if (pause == 6754)
            {
                string message11 = messageArray11[6];
                TextWriter.AddWriter_Static(messageText, message11, .05f, true);
            }

            if (pause == 7754)
            {
                Message11.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}