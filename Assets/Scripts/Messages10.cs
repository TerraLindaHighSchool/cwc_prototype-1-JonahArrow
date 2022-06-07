using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Messages10 : MonoBehaviour
{
    public GameObject Message10;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager10").Find("Text10").GetComponent<Text>();

        transform.Find("messager10");
        {
            string[] messageArray10 = new string[4]
            {
            "Congratulations, Player!",
            "You beat the game!",
            "I've gathered some valuble intel from your playthrough.",
            "Now go live happily ever after with your family."
            };

            if (Message10.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message10.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message10 = messageArray10[0];
                TextWriter.AddWriter_Static(messageText, message10, .05f, true);
            }

            if (pause == 201)
            {
                string message10 = messageArray10[1];
                TextWriter.AddWriter_Static(messageText, message10, .05f, true);
            }

            if (pause == 401)
            {
                string message10 = messageArray10[2];
                TextWriter.AddWriter_Static(messageText, message10, .05f, true);
            }

            if (pause == 601)
            {
                string message10 = messageArray10[3];
                TextWriter.AddWriter_Static(messageText, message10, .05f, true);
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
