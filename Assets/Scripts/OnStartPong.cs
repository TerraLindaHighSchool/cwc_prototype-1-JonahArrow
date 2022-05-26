using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartPong : MonoBehaviour
{
    public GameObject Pong;
    public GameObject Thing;
    public int Count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Count++;
        if (Count == 1000)
        {
            Pong.gameObject.SetActive(true);
        }
        if (Count == 6000)
        {
            Thing.gameObject.SetActive(true);
        }
    }
}
