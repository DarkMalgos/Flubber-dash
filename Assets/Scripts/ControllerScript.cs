using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{

    [SerializeField]
    private GameObject Flubber;

    [SerializeField]
    private float Speed;

    [SerializeField]
    [Range(0, 1000)]
    private float JumpPower;

    private bool MoveIt = false;
    private int Axe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveIt)
        {
            Vector2 CurrentSpeed = Flubber.GetComponent<Rigidbody2D>().velocity;
            Vector2 MaxSpeed = Axe * Speed * Flubber.transform.right;
            Flubber.GetComponent<Rigidbody2D>().AddForce(MaxSpeed - CurrentSpeed);
        }
    }

    public void moveItNow(int axe)
    {
        MoveIt = true;
        Axe = axe;
        
    }

    public void stopItNow()
    {
        MoveIt = false;
    }

    public void jumpIt()
    {
        if (Flubber.GetComponent<FlubberProperty>().isGrounded)
            Flubber.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpPower));
    }
}
