using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages15 : MonoBehaviour
{
    public GameObject Message15;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager15").Find("Text15").GetComponent<Text>();

        transform.Find("messager15");
        {
            string[] messageArray15 = new string[]
            {
            "Really?"
            };

            if (Message15.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message15.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 4)
            {
                string message15 = messageArray15[0];
                TextWriter.AddWriter_Static(messageText, message15, .05f, true);
            }

            if (pause == 754)
            {
                Message15.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}