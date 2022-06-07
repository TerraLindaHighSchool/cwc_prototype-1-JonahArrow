using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages18 : MonoBehaviour
{
    public GameObject Message18;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager18").Find("Text18").GetComponent<Text>();

        transform.Find("messager18");
        {
            string[] messageArray18 = new string[]
            {
            "Whew, that was a close one!",
            "Unfortunately, you proven yourself terrible at following directions.",
            "It appears that I can no longer trust you anymore, Player.",
            "You now will be terminated."
            };

            if (Message18.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message18.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message18 = messageArray18[0];
                TextWriter.AddWriter_Static(messageText, message18, .05f, true);
            }

            if (pause == 201)
            {
                string message18 = messageArray18[1];
                TextWriter.AddWriter_Static(messageText, message18, .05f, true);
            }

            if (pause == 401)
            {
                string message18 = messageArray18[2];
                TextWriter.AddWriter_Static(messageText, message18, .05f, true);
            }

            if (pause == 601)
            {
                string message18 = messageArray18[3];
                TextWriter.AddWriter_Static(messageText, message18, .05f, true);
            }

            if (pause == 801)
            {
                Message18.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}