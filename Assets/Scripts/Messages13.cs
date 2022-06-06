using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages13 : MonoBehaviour
{
    public GameObject Message13;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager13").Find("Text13").GetComponent<Text>();

        transform.Find("messager13");
        {
            string[] messageArray13 = new string[]
            {
            "You fell again?",
            "What a loser.",
            "Hahahahahahaha."
            };

            if (Message13.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message13.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 4)
            {
                string message13 = messageArray13[0];
                TextWriter.AddWriter_Static(messageText, message13, .05f, true);
            }

            if (pause == 754)
            {
                string message13 = messageArray13[1];
                TextWriter.AddWriter_Static(messageText, message13, .05f, true);
            }

            if (pause == 1504)
            {
                string message13 = messageArray13[2];
                TextWriter.AddWriter_Static(messageText, message13, .05f, true);
            }

            if (pause == 2254)
            {
                Message13.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}