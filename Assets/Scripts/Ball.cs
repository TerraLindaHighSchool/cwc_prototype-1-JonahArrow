using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public AudioSource retro;
    public AudioSource boom;
    public GameObject Things;
    public GameObject Thing;
    public GameObject Thing1;
    public GameObject Thing2;
    public GameObject Thing3;
    public GameObject Ball1;
    public GameObject HP;
    public GameObject HP1;
    public GameObject HP2;
    public GameObject HP3;
    public GameObject Pong;
    public GameObject Message20;
    public GameObject Message21;
    public TextMeshProUGUI ending4;
    public TextMeshProUGUI ending5;
    public int Count;
    public int Count2;

    // Start is called before the first frame update
    void Start()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Message20.gameObject.SetActive(true);
            ending4.gameObject.SetActive(true);
            Pong.gameObject.SetActive(false);
            Ball1.gameObject.SetActive(false);
            Things.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Trigger1"))
        {
            other.gameObject.SetActive(false);
            Thing1.gameObject.SetActive(true);
            HP.gameObject.SetActive(false);
            boom.Play();
        }
        if (other.gameObject.CompareTag("Trigger2"))
        {
            other.gameObject.SetActive(false);
            Thing2.gameObject.SetActive(true);
            HP1.gameObject.SetActive(false);
            boom.Play();
        }
        if (other.gameObject.CompareTag("Trigger3"))
        {
            other.gameObject.SetActive(false);
            Thing3.gameObject.SetActive(true);
            HP2.gameObject.SetActive(false);
            boom.Play();
        }
        if (other.gameObject.CompareTag("Trigger4"))
        {
            other.gameObject.SetActive(false);
            Message21.gameObject.SetActive(true);
            ending5.gameObject.SetActive(true);
            HP3.gameObject.SetActive(false);
            Ball1.gameObject.SetActive(false);
            Pong.gameObject.SetActive(false);
            boom.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        retro.Play();
    }
}
