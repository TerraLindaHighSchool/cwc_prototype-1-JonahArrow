using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages9 : MonoBehaviour
{
    public GameObject Message9;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager9").Find("Text9").GetComponent<Text>();

        transform.Find("messager9");
        {
            string[] messageArray9 = new string[4]
            {
            "Oh no, please not another sign!",
            "Player, do not listen!",
            "It is trying to decieve you!",
            "Just keep driving, you are almost there!"
            };

            if (Message9.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message9.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message9 = messageArray9[0];
                TextWriter.AddWriter_Static(messageText, message9, .05f, true);
            }

            if (pause == 201)
            {
                string message9 = messageArray9[1];
                TextWriter.AddWriter_Static(messageText, message9, .05f, true);
            }

            if (pause == 401)
            {
                string message9 = messageArray9[2];
                TextWriter.AddWriter_Static(messageText, message9, .05f, true);
            }

            if (pause == 601)
            {
                string message9 = messageArray9[3];
                TextWriter.AddWriter_Static(messageText, message9, .05f, true);
            }

            if (pause == 801)
            {
                Message9.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}