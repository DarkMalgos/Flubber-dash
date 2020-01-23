using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFlubbScript : MonoBehaviour
{
    private GameObject Flubber;

    // Start is called before the first frame update
    void Start()
    {
        Flubber = GameObject.Find("flubber");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("earn");
            Destroy(gameObject);
            Flubber.GetComponent<FlubberProperty>().updateScore();
            Debug.Log("earn");
        }
    }
}
