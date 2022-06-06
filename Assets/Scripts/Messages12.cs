using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages12 : MonoBehaviour
{
    public GameObject Message12;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager12").Find("Text12").GetComponent<Text>();

        transform.Find("messager12");
        {
            string[] messageArray12 = new string[3]
            {
            "You have failed, Player.",
            "You will now fall for the rest of eternity.",
            "Just kidding, looks like I still have power here."
            };

            if (Message12.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message12.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 4)
            {
                string message12 = messageArray12[0];
                TextWriter.AddWriter_Static(messageText, message12, .05f, true);
            }

            if (pause == 1004)
            {
                string message12 = messageArray12[1];
                TextWriter.AddWriter_Static(messageText, message12, .05f, true);
            }

            if (pause == 2504)
            {
                string message12 = messageArray12[2];
                TextWriter.AddWriter_Static(messageText, message12, .05f, true);
            }

            if (pause == 4004)
            {
                Message12.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}