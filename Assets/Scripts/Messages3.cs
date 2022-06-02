using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages3 : MonoBehaviour
{
    public GameObject Message3;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager3").Find("Text3").GetComponent<Text>();

        transform.Find("messager3");
        {
            string[] messageArray3 = new string[3]
            {
            "Player, heed my warning.",
            "Do NOT press that button!",
            "Please, I beg of you."
            };

            if (Message3.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message3.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 6)
            {
                string message3 = messageArray3[0];
                TextWriter.AddWriter_Static(messageText, message3, .05f, true);
            }

            if (pause == 756)
            {
                string message3 = messageArray3[1];
                TextWriter.AddWriter_Static(messageText, message3, .05f, true);
            }

            if (pause == 1506)
            {
                string message3 = messageArray3[2];
                TextWriter.AddWriter_Static(messageText, message3, .05f, true);
            }

            if (pause == 2226)
            {
                Message3.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}