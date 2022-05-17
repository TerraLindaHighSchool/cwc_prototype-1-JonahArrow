using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public int coinCount = 0;
    public GameObject Camera;
    [SerializeField] private bool moving = false;
    [SerializeField] private bool OnGround = false;
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private bool Fall1 = true;
    private bool Fall2 = false;
    private bool Fall3 = false;
    private bool Trigger;
    public int Count;
    public int Count2;
    public int Count3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        IsMoving();

        IsOnGround();
    }

    // Checks if vehicle is moving
    void IsMoving()
    {
        if (forwardInput == 0)
        {
            moving = false;
        }
        else
        {
            moving = true;
        }
        if (moving == true)
        {
            turnSpeed = 45.0f;
        }
        if (moving == false)
        {
            turnSpeed = 0.0f;
        }
    }

    // Checks if vehicle is on the ground
    void IsOnGround()
    {
        if (OnGround == false)
        {

        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinCount++;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        OnGround = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Trigger = true;
        }
    }

    private void MapFall()
    {
        if (Trigger && Fall1 == true)
        {
            Count++;
            if (Count == 100)
            {
                Trigger = false;
                gameObject.transform.position = new Vector3(0, 1, 0);
                Fall1 = false;
                Fall2 = true;
                Count = 0;
            }

        }
        if (Trigger && Fall2 == true)
        {
            Count2++;
            if (Count2 == 200)
            {
                Trigger = false;
                gameObject.transform.position = new Vector3(0, 1, 0);
                Fall2 = false;
                Fall3 = true;
                Count2 = 0;
            }
        }
        if (Trigger && Fall3 == true)
        {
            Count3++;
            if (Count3 == 200)
            {
                Trigger = false;
                Count3 = 0;
            }
        }
    }
}
