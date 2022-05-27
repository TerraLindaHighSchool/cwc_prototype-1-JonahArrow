using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public GameObject Ball;
    public bool isBump1;
    private Vector3 offset = new Vector3(12, 0, 0);
    public float speed = 5f;
    public float moveSpeed = 3f;
    float boundery1 = 6f;
    float boundery2 = -6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBump1)
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
        }
        if (!isBump1)
        {
            transform.position = new Vector2(12, Ball.transform.position.y);
        }
        if (transform.position.y >= boundery1)
        {
            transform.position = new Vector3(transform.position.x, boundery1, 0);
        }
        else if (transform.position.y <= boundery2)
        {
            transform.position = new Vector3(transform.position.x, boundery2, 0);
        }
    }
}
