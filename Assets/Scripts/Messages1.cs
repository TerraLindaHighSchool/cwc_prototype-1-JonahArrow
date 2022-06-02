using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages1 : MonoBehaviour
{
    public GameObject Message1;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager1").Find("Text1").GetComponent<Text>();

        transform.Find("messager1");
        {
            string[] messageArray1 = new string[7]
            {
            "Lo and behold, Player, countless hours of sweat, blood, and tears.",
            "All culminating into one masterpiece of art.",
            "Every tree, every rock, every inch of ground you see before you, crafted to perfection.",
            "Sadly, this perfection is rather flawed, or rather, the public perception of art is flawed.",
            "People say, “there's literally nothing to do in this game,” or “I rather watch paint dry.”",
            "Idiots, the whole lot of them.",
            "Don't they understand the meaning?"
            };

            if (Message1.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message1.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 4)
            {
                string message1 = messageArray1[0];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 1504)
            {
                string message1 = messageArray1[1];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 3004)
            {
                string message1 = messageArray1[2];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 5004)
            {
                string message1 = messageArray1[3];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 7004)
            {
                string message1 = messageArray1[4];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 9004)
            {
                string message1 = messageArray1[5];
                TextWriter.AddWriter_Static(messageText, message1, .05f, true);
            }

            if (pause == 10004)
            {
                Message1.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}
