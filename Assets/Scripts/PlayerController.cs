using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int coinCount = 0;
    public GameObject Camera;
    public TextMeshProUGUI ending1;
    public TextMeshProUGUI ending2;
    public TextMeshProUGUI ending5;
    private bool gameStart = false;
    private bool moving = false;
    private bool OnGround = false;
    private bool Trigger = false;
    private bool Trigger1 = false;
    private bool Trigger2 = false;
    private bool Trigger3 = false;
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public int Count;
    public int Count2;
    public int Count3;
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

        if(coinCount == 5)
        {
            ending5.gameObject.SetActive(true);
        }

        // Takes player to next level
        NextLevel();

        // Checks if vehicle is moving
        IsMoving();

        // Checks if vehicle is on ground
        IsOnGround();

        // Checks for falling off the map
        MapFall();

        // Checks for trigger for ending 1
        Ending1();
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinCount++;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Trigger"))
        {
            Trigger = true;
        }
        if (other.gameObject.CompareTag("Trigger1"))
        {
            Trigger1 = true;
        }
        if (other.gameObject.CompareTag("Trigger2"))
        {
            Trigger2 = true;
        }
        if (other.gameObject.CompareTag("Trigger3"))
        {
            Trigger3 = true;
        }
    }

    // Checks colliders for interactions
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        OnGround = false;
    }

    private void MapFall() 
    {
        if(Trigger && Fall1 == true) 
        {
            Count++;
            if(Count == 100)
            {
                Trigger = false;
                gameObject.transform.position = new Vector3(0, 1, 0);
                Fall1 = false;
                Fall2 = true;
                Count = 0;
            }
            
        }
        if(Trigger && Fall2 == true)
        {
            Count2++;
            if(Count2 == 200)
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
                ending2.gameObject.SetActive(true);
                Count3 = 0;
            }
        }
    }

    public void NextLevel()
    {
        if (Trigger2 == true)
        {
            loadlevel("RaceTrack");
        }
        
        if (Trigger1 == true)
        {

        }
    }

    private void Ending1()
    {
        if (Trigger3 == true)
        {
            ending1.gameObject.SetActive(true);
        }
    }

    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
