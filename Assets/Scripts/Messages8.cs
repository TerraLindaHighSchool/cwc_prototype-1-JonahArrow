using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages8 : MonoBehaviour
{
    public GameObject Message8;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager8").Find("Text8").GetComponent<Text>();

        transform.Find("messager8");
        {
            string[] messageArray8 = new string[5]
            {
            "Well done Player.",
            "You have gone quite far now.",
            "I would like to inform you that you are about halfway there.",
            "Or perhaps I'm lying, pehaps we arent halfway there.",
            "It would ruin the spirit of the game knowing, wouldn't it?"
            };

            if (Message8.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message8.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 7)
            {
                string message8 = messageArray8[0];
                TextWriter.AddWriter_Static(messageText, message8, .05f, true);
            }

            if (pause == 756)
            {
                string message8 = messageArray8[1];
                TextWriter.AddWriter_Static(messageText, message8, .05f, true);
            }

            if (pause == 1756)
            {
                string message8 = messageArray8[2];
                TextWriter.AddWriter_Static(messageText, message8, .05f, true);
            }

            if (pause == 3226)
            {
                string message8 = messageArray8[3];
                TextWriter.AddWriter_Static(messageText, message8, .05f, true);
            }

            if (pause == 4756)
            {
                string message8 = messageArray8[4];
                TextWriter.AddWriter_Static(messageText, message8, .05f, true);
            }

            if (pause >= 6256)
            {
                Message8.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}