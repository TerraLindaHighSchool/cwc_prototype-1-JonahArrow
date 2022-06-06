using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour
{
    public int coinCount = 0;
    public GameObject Camera;
    public GameObject trigger3;
    public GameObject messager11;
    public GameObject messager12;
    public GameObject messager13;
    public GameObject messager14;
    public GameObject messager15;
    [SerializeField] private bool moving = false;
    [SerializeField] private bool OnGround = false;
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private bool Fall1 = true;
    private bool Fall2 = false;
    private bool Fall3 = false;
    private bool Trigger = false;
    private bool Trigger1 = false;
    private bool Trigger2 = false;
    private bool Trigger3 = false;
    private bool CanMove = false;
    public int Count;
    public int Count2;
    public int Count3;

    // Start is called before the first frame update
    void Start()
    {
        messager11.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        IsMoving();

        IsOnGround();

        MapFall();

        NextLevel();

        if(CanMove == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }

        if (messager11.activeInHierarchy == false)
        {
            CanMove = true;
        }
        else if (messager15.activeInHierarchy == true)
        {
            CanMove = false;
        }

        if (Trigger2 == true)
        {
            trigger3.gameObject.SetActive(true);
        }
    }
    public void NextLevel()
    {
        if (Trigger3 == true)
        {
            loadlevel("Choice");
        }

        if (Trigger1 == true)
        {
            loadlevel("Pong");
        }
    }
    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
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

    private void MapFall()
    {
        if (Trigger && Fall1 == true)
        {
            Count++;
            messager12.gameObject.SetActive(true);
            if (Count == 4004)
            {
                Trigger = false;
                gameObject.transform.position = new Vector3(0, 8, -10);
                gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
                Fall1 = false;
                Fall2 = true;
                Count = 0;
            }

        }
        if (Trigger && Fall2 == true)
        {
            Count2++;
            messager13.gameObject.SetActive(true);
            if (Count2 == 2254)
            {
                Trigger = false;
                gameObject.transform.position = new Vector3(0, 8, -10);
                gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
                Fall2 = false;
                Fall3 = true;
                Count2 = 0;
            }
        }
        if (Trigger && Fall3 == true)
        {
            Count3++;
            messager14.gameObject.SetActive(true);
            if (Count3 == 754)
            {
                Trigger = false;
                gameObject.transform.position = new Vector3(0, 8, -10);
                gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
                Count3 = 0;
            }
        }
    }
}
