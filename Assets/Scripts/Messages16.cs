using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages16 : MonoBehaviour
{
    public GameObject Message16;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager16").Find("Text16").GetComponent<Text>();

        transform.Find("messager16");
        {
            string[] messageArray16 = new string[]
            {
            "Where are we?",
            "Oh no no no no no.",
            "Don't do it Player.",
            "Please, I'm begging you."
            };

            if (Message16.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message16.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message16 = messageArray16[0];
                TextWriter.AddWriter_Static(messageText, message16, .05f, true);
            }

            if (pause == 201)
            {
                string message16 = messageArray16[1];
                TextWriter.AddWriter_Static(messageText, message16, .05f, true);
            }

            if (pause == 401)
            {
                string message16 = messageArray16[2];
                TextWriter.AddWriter_Static(messageText, message16, .05f, true);
            }

            if (pause == 601)
            {
                string message16 = messageArray16[3];
                TextWriter.AddWriter_Static(messageText, message16, .05f, true);
            }

            if (pause == 801)
            {
                Message16.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}