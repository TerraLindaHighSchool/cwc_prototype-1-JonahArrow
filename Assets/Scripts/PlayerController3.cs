using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController3 : MonoBehaviour
{
    public int coinCount = 0;
    public TextMeshProUGUI ending3;
    public GameObject messager16;
    public GameObject messager17;
    public GameObject messager18;
    public GameObject Player;
    public GameObject Camera;
    public GameObject trigger3;
    public GameObject Door;
    [SerializeField] private bool moving = false;
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private bool Trigger = false;
    private bool Trigger2 = false;
    private bool Trigger3 = false;
    private bool CanMove = false;
    public int Count;
    public int Count2;
    public int Count3;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        messager16.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if(CanMove == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }

        if(Trigger2 == true)
        {
            Player.gameObject.transform.position = new Vector3(1000, 0, 0);
            Camera.gameObject.transform.rotation = new Quaternion(0, 90, 0, 0);
            messager18.gameObject.SetActive(true);
            ending3.gameObject.SetActive(true);
            Trigger2 = false;
            // Audio goes here
        }

        if(Trigger3 == true)
        {
            trigger3.gameObject.SetActive(false);
            messager17.gameObject.SetActive(true);
            Door.gameObject.SetActive(true);
            Trigger3 = false;
        }

        if (messager16.activeInHierarchy == false)
        {
            CanMove = true;
        }

        if (messager18.activeInHierarchy == true)
        {
            Count++;
            if(Count == 800)
            {
                loadlevel("Prototype 1");
            }
        }

        IsMoving();

        NextLevel();
    }

    public void NextLevel()
    {
        if (Trigger == true)
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

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinCount++;
            other.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Trigger = true;
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

    
}
