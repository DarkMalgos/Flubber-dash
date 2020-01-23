using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("init");
        GameObject flubber = FindObjectOfType<FlubberProperty>().gameObject;
        flubber.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        flubber.GetComponent<FlubberProperty>().setStartZone(transform.position);
        //flubber.GetComponent<FlubberProperty>().ScoreLabel = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
