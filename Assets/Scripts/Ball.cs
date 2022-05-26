using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public AudioSource retro;
    public GameObject Thing;
    public GameObject Thing1;
    public GameObject Thing2;
    public GameObject Thing3;
    public GameObject Pong;
    public TextMeshProUGUI ending4;
    public TextMeshProUGUI ending5;

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
            ending4.gameObject.SetActive(true);
            Pong.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Trigger1"))
        {
            other.gameObject.SetActive(false);
            Thing1.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("Trigger2"))
        {
            other.gameObject.SetActive(false);
            Thing2.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("Trigger3"))
        {
            other.gameObject.SetActive(false);
            Thing3.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("Trigger4"))
        {
            other.gameObject.SetActive(false);
            ending5.gameObject.SetActive(true);
            Pong.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        retro.Play();
    }
}
