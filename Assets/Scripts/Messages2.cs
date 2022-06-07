using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages2 : MonoBehaviour
{
    public GameObject Message2;
    public Text messageText;
    [SerializeField] private int pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        messageText = transform.Find("messager2").Find("Text2").GetComponent<Text>();

        transform.Find("messager2");
        {
            string[] messageArray2 = new string[1]
            {
            "Hmmmm, I don't remember placing that sign."
            };

            if (Message2.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message2.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 1)
            {
                string message2 = messageArray2[0];
                TextWriter.AddWriter_Static(messageText, message2, .05f, true);
            }

            if (pause == 201)
            {
                Message2.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}
