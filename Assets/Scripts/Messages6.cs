using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages6 : MonoBehaviour
{
    public GameObject Message6;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager6").Find("Text6").GetComponent<Text>();

        transform.Find("messager6");
        {
            string[] messageArray6 = new string[4]
            {
            "You did it again.",
            "There's nothing back there, but you went back anyway.",
            "Did you want to see my reaction?",
            "Don't do it again ok?"
            };

            if (Message6.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message6.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 6)
            {
                string message6 = messageArray6[0];
                TextWriter.AddWriter_Static(messageText, message6, .05f, true);
            }

            if (pause == 756)
            {
                string message6 = messageArray6[1];
                TextWriter.AddWriter_Static(messageText, message6, .05f, true);
            }

            if (pause == 1756)
            {
                string message6 = messageArray6[2];
                TextWriter.AddWriter_Static(messageText, message6, .05f, true);
            }

            if (pause == 2756)
            {
                string message6 = messageArray6[3];
                TextWriter.AddWriter_Static(messageText, message6, .05f, true);
            }

            if (pause >= 3754)
            {
                Message6.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}