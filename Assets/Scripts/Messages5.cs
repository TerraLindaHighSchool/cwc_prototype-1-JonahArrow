using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages5 : MonoBehaviour
{
    public GameObject Message5;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager5").Find("Text5").GetComponent<Text>();

        transform.Find("messager5");
        {
            string[] messageArray5 = new string[16]
            {
            "Whew, thank you Player for avoiding that thing.", // 0
            "There is no knowing what that could have been.", // 1
            "Anyways, back to what I was talking about.", // 2
            "The public perseption of my game is completely undeserved.", // 3
            "People just don't look past the surface, looking within the true meaning of the game.", // 4
            "Didn't they see?", // 5
            "Didn't they understand that the game is a metaphor for love?", // 6
            "Didn't they cry when it was revealed that the story was of the journey of Bob Smith?", // 7
            "His quest to go home after returning from the war?", // 8
            "His journey to return to his farm to live a life of peace?", // 9
            "His desire to see his wife and daughter again, even after all these years?", // 10
            "Ooops, my bad.", // 11
            "I must have spoiled everything for you.", // 12
            "I am so sorry, sorry that you will never experience the heartbreaking story with fresh eyes.", // 13
            "Anyways, Player, this is where you come in and fix the game for me.", // 14
            "Play through the game, tell me what I can improve, and I might consider fixing it." // 15
            };

            if (Message5.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message5.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 6)
            {
                string message5 = messageArray5[0];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 1506)
            {
                string message5 = messageArray5[1];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 3006)
            {
                string message5 = messageArray5[2];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 4506)
            {
                string message5 = messageArray5[3];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 6006)
            {
                string message5 = messageArray5[4];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 8006)
            {
                string message5 = messageArray5[5];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 8756)
            {
                string message5 = messageArray5[6];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 10256)
            {
                string message5 = messageArray5[7];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 12256)
            {
                string message5 = messageArray5[8];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 13756)
            {
                string message5 = messageArray5[9];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 15256)
            {
                string message5 = messageArray5[10];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 17256)
            {
                string message5 = messageArray5[11];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 18006)
            {
                string message5 = messageArray5[12];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 19006)
            {
                string message5 = messageArray5[13];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 21006)
            {
                string message5 = messageArray5[14];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 23006)
            {
                string message5 = messageArray5[15];
                TextWriter.AddWriter_Static(messageText, message5, .05f, true);
            }

            if (pause == 25006)
            {
                Message5.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}