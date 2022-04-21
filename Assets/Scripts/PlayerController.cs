using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int coinCount = 0;
    public GameObject Camera;
    private bool gameStart = false;
    private bool moving = false;
    private bool OnGround = false;
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameStart = true;
        }
        if (gameStart == false)
        {

        }
        if (gameStart == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
            Camera.gameObject.SetActive(false);
        }

        // Checks if vehicle is moving
        IsMoving();

        // Checks if vehicle is on ground
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
        if(OnGround == false)
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
}
