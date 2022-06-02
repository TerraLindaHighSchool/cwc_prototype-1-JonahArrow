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
            "Please, I beg of you."
            };

            if (Message4.activeInHierarchy == true)
            {
                pause++;
            }
            else if (Message4.activeInHierarchy == false)
            {
                pause = 0;
            }

            if (pause == 6)
            {
                string message4 = messageArray4[0];
                TextWriter.AddWriter_Static(messageText, message4, .05f, true);
            }

            if (pause == 756)
            {
                string message4 = messageArray4[1];
                TextWriter.AddWriter_Static(messageText, message4, .05f, true);
            }

            if (pause == 1506)
            {
                string message4 = messageArray4[2];
                TextWriter.AddWriter_Static(messageText, message4, .05f, true);
            }

            if (pause == 2226)
            {
                Message4.gameObject.SetActive(false);
            }
        };
    }

    private void Awake()
    {

    }
}