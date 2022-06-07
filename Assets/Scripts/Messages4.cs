using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages4 : MonoBehaviour
{
    public GameObject Message4;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager4").Find("Text4").GetComponent<Text>();

        transform.Find("messager4");
        {
            string[] messageArray4 = new string[3]
            {
            "Player, heed my warning.",
            "Do NOT press that button!",
            "This is not supposed to be in the game!"
            };

            if (Message4.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message4.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message4 = messageArray4[0];
                TextWriter.AddWriter_Static(messageText, message4, .05f, true);
            }

            if (pause == 201)
            {
                string message4 = messageArray4[1];
                TextWriter.AddWriter_Static(messageText, message4, .05f, true);
            }

            if (pause == 401)
            {
                string message4 = messageArray4[2];
                TextWriter.AddWriter_Static(messageText, message4, .05f, true);
            }

            if (pause == 601)
            {
                Message4.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}