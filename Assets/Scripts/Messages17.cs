using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages17 : MonoBehaviour
{
    public GameObject Message17;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager17").Find("Text17").GetComponent<Text>();

        transform.Find("messager17");
        {
            string[] messageArray17 = new string[]
            {
            "PLAYER, PLEASE!",
            "COME WITH ME, COME THROUGH THIS DOOR!",
            "DON'T PRESS THE BUTTON, I BEG OF YOU!"
            };

            if (Message17.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message17.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message17 = messageArray17[0];
                TextWriter.AddWriter_Static(messageText, message17, .05f, true);
            }

            if (pause == 201)
            {
                string message17 = messageArray17[1];
                TextWriter.AddWriter_Static(messageText, message17, .05f, true);
            }

            if (pause == 401)
            {
                string message17 = messageArray17[2];
                TextWriter.AddWriter_Static(messageText, message17, .05f, true);
            }

            if (pause == 601)
            {
                Message17.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}