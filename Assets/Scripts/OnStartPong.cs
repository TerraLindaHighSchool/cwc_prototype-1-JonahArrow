using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartPong : MonoBehaviour
{
    public GameObject Pong;
    public GameObject Thing;
    public GameObject Ball;
    public GameObject messager19;
    public GameObject messager20;
    public GameObject messager21;
    public int Count;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        messager19.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (messager19.activeInHierarchy == false)
        {
            Count++;
        }
        if (Count == 1)
        {
            Pong.gameObject.SetActive(true);
        }
        if (Count == 50)
        {
            Ball.gameObject.SetActive(true);
        }
        if (Count == 300)
        {
            Thing.gameObject.SetActive(true);
        }
    }
}
