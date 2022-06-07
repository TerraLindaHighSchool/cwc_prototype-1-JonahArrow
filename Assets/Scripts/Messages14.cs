using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages14 : MonoBehaviour
{
    public GameObject Message14;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager14").Find("Text14").GetComponent<Text>();

        transform.Find("messager14");
        {
            string[] messageArray14 = new string[]
            {
            "Really?"
            };

            if (Message14.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message14.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message14 = messageArray14[0];
                TextWriter.AddWriter_Static(messageText, message14, .05f, true);
            }

            if (pause == 201)
            {
                Message14.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}