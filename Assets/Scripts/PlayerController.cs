using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int coinCount = 0;
    public AudioSource talking;
    public GameObject Camera;
    public TextMeshProUGUI ending1;
    public TextMeshProUGUI ending2;
    public TextMeshProUGUI ending5;
    public GameObject messager;
    public GameObject messager1;
    public GameObject messager2;
    public GameObject messager3;
    public GameObject messager4;
    public GameObject messager5;
    public GameObject messager6;
    public GameObject messager7;
    public GameObject messager8;
    public GameObject messager9;
    public GameObject messager10;
    private bool gameStart = false;
    private bool moving = false;
    private bool OnGround = false;
    private bool Trigger = false;
    private bool Trigger1 = false;
    private bool Trigger2 = false;
    private bool Trigger3 = false;
    private bool Trigger4 = false;
    private bool Trigger5 = false;
    private bool Trigger6 = false;
    private bool Trigger7 = false;
    private bool Trigger8 = false;
    private bool Trigger9 = false;
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
    private bool startMessage = true;
    private bool CanMove = false;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        // Detects imput "Space" to start game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameStart = true;
            if(startMessage == true)
            {
                messager.gameObject.SetActive(true);
            }
            startMessage = false;
        }
        if (gameStart == false)
        {

        }
        if (gameStart == true)
        {
            Camera.gameObject.SetActive(false);
        }

        if(CanMove == true)
        {
            // Movement transforms of player
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        } 
        else
        {

        }

        if(messager.activeInHierarchy == true)
        {
            CanMove = false;
        }
        else
        {
            CanMove = true;
        }

        if (coinCount == 5)
        {
            ending5.gameObject.SetActive(true);
        }

        if(Trigger1 == true)
        {
            messager1.gameObject.SetActive(true);
            Trigger1 = false;
        }

        if(Trigger4 == true)
        {
            messager2.gameObject.SetActive(true);
            Trigger4 = false;
        }

        if (Trigger5 == true)
        {
            messager3.gameObject.SetActive(true);
            Trigger5 = false;
        }

        if (Trigger6 == true)
        {
            messager4.gameObject.SetActive(true);
            Trigger6 = false;
        }

        if (Trigger7 == true)
        {
            messager5.gameObject.SetActive(true);
            Trigger7 = false;
        }

        if (Trigger8 == true)
        {
            messager8.gameObject.SetActive(true);
            Trigger8 = false;
        }

        if (Trigger9 == true)
        {
            messager9.gameObject.SetActive(true);
            Trigger9 = false;
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
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Trigger2"))
        {
            Trigger2 = true;
        }
        if (other.gameObject.CompareTag("Trigger3"))
        {
            Trigger3 = true;
        }
        if (other.gameObject.CompareTag("Trigger4"))
        {
            Trigger4 = true;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Trigger5"))
        {
            Trigger5 = true;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Trigger6"))
        {
            Trigger6 = true;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Trigger7"))
        {
            Trigger7 = true;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Trigger8"))
        {
            Trigger8 = true;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Trigger9"))
        {
            Trigger9 = true;
            other.gameObject.SetActive(false);
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
            messager3.gameObject.SetActive(true);
            if (Count >= 601)
            {
                Trigger = false;
                gameObject.transform.position = new Vector3(0, -0.02876592f, 0);
                Fall1 = false;
                Fall2 = true;
                Count = 0;
            }
            
        }
        if(Trigger && Fall2 == true)
        {
            Count2++;
            messager6.gameObject.SetActive(true);
            if (Count2 >= 801)
            {
                Trigger = false;
                gameObject.transform.position = new Vector3(0, -0.02876592f, 0);
                Fall2 = false;
                Fall3 = true;
                Count2 = 0;
            }
        }
        if (Trigger && Fall3 == true)
        {
            Count3++;
            messager7.gameObject.SetActive(true);
            ending2.gameObject.SetActive(true);
            if (Count3 >= 801)
            {
                loadlevel("Prototype 1");
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

    private void Ending1()
    {
        if (Trigger3 == true)
        {
            messager10.gameObject.SetActive(true);
            ending1.gameObject.SetActive(true);
        }
    }

    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
