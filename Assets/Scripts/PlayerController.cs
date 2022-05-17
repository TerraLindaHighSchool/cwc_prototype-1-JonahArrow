using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int coinCount = 0;
    public GameObject Camera;
    private bool gameStart = false;
    private bool moving = false;
    private bool OnGround = false;
    private bool Trigger = false;
    private bool Trigger2 = false;
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private int Count;
    private int Count2;
    private bool Fall1 = true;
    private bool Fall2 = false;
    private bool Fall3 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Detects imput "Space" to start game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameStart = true;
        }
        if (gameStart == false)
        {

        }
        if (gameStart == true)
        {
            // Movement transforms of player
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
            Camera.gameObject.SetActive(false);
        }

        // Takes player to next level
        NextLevel();

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
        if (OnGround == false)
        {

        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
        }
    }

    // Checks colliders for interactions
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
        if (other.gameObject.CompareTag("Trigger")) 
        {
            Trigger = true;
        }
        if (other.gameObject.CompareTag("Trigger2"))
        {
            Trigger2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        OnGround = false;
    }

    private void MapFall() 
    {
        if(Trigger == true) 
        {
            if(Fall1 == true) 
            {
                Count++;
                if(Count == 100)
                {
                    Fall1 = false;
                    Fall2 = true;
                }
            }
            if(Fall2 == true)
            {
                Count2++;
                if(Count == 200)
                {
                    Fall2 = false;
                    Fall3 = true;
                }
            }
            if(Fall3 == true)
            {

            }
        }
    }

    public void NextLevel()
    {
        if (Trigger2 == true)
        {
            loadlevel("RaceTrack");
        }
    }

    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
