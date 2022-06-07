using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Messages21 : MonoBehaviour
{
    public GameObject Message21;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager21").Find("Text21").GetComponent<Text>();

        transform.Find("messager21");
        {
            string[] messageArray21 = new string[]
            {
            "Congratulations.",
            "You have beaten me.",
            "You will be spared while the rest of this world parishes.",
            "Good job!"
            };

            if (Message21.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message21.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message21 = messageArray21[0];
                TextWriter.AddWriter_Static(messageText, message21, .05f, true);
            }

            if (pause == 201)
            {
                string message21 = messageArray21[1];
                TextWriter.AddWriter_Static(messageText, message21, .05f, true);
            }

            if (pause == 401)
            {
                string message21 = messageArray21[2];
                TextWriter.AddWriter_Static(messageText, message21, .05f, true);
            }

            if (pause == 601)
            {
                string message21 = messageArray21[3];
                TextWriter.AddWriter_Static(messageText, message21, .05f, true);
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