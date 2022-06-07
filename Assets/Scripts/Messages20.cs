using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Messages20 : MonoBehaviour
{
    public GameObject Message20;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager20").Find("Text20").GetComponent<Text>();

        transform.Find("messager20");
        {
            string[] messageArray20 = new string[]
            {
            "Oh how sad!",
            "You have lost, now your soul is mine.",
            "Well goodbye Player.",
            "It has been fun playing with you."
            };

            if (Message20.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message20.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message20 = messageArray20[0];
                TextWriter.AddWriter_Static(messageText, message20, .05f, true);
            }

            if (pause == 201)
            {
                string message20 = messageArray20[1];
                TextWriter.AddWriter_Static(messageText, message20, .05f, true);
            }

            if (pause == 401)
            {
                string message20 = messageArray20[2];
                TextWriter.AddWriter_Static(messageText, message20, .05f, true);
            }

            if (pause == 601)
            {
                string message20 = messageArray20[3];
                TextWriter.AddWriter_Static(messageText, message20, .05f, true);
            }

            if (pause == 801)
            {
                loadlevel("Prototype 1");
            }
        };
    }

    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    private void Awake()
    {

    }
}