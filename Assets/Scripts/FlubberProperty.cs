using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FlubberProperty : MonoBehaviour
{
    [SerializeField]
    private int Score = 0;

    public TextMeshProUGUI ScoreLabel;

    private Vector2 StartZone;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setStartZone(Vector2 startPosition)
    {
        StartZone = startPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "ennemy")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            transform.position = StartZone;
        }

       if (collision.gameObject.tag == "floor")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            isGrounded = false;
        }
    }

    public void updateScore()
    {
        Debug.Log("update the score");
        Score += 1;
        ScoreLabel.text = Score.ToString();
        Debug.Log(Score);
    }
}
