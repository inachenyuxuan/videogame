using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    Rigidbody2D _rb;
    Animator myAnimator;
    //Configuration
    public float speed;
    public float rotationSpeed;
    private string current_key;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            if (current_key == "UpArrow")
            {
                myAnimator.SetBool("up", true);
                myAnimator.SetBool("up_walk", false);
                myAnimator.SetBool("down_walk", false);
                myAnimator.SetBool("left_walk", false);
                myAnimator.SetBool("right_walk", false);
            }
            if (current_key == "DownArrow")
            {
                myAnimator.SetBool("down", true);
                myAnimator.SetBool("up_walk", false);
                myAnimator.SetBool("down_walk", false);
                myAnimator.SetBool("left_walk", false);
                myAnimator.SetBool("right_walk", false);
            }
            if (current_key == "LeftArrow")
            {
                myAnimator.SetBool("left", true);
                myAnimator.SetBool("up_walk", false);
                myAnimator.SetBool("down_walk", false);
                myAnimator.SetBool("left_walk", false);
                myAnimator.SetBool("right_walk", false);
            }
            if (current_key == "RightArrow")
            {
                myAnimator.SetBool("right", true);
                myAnimator.SetBool("up_walk", false);
                myAnimator.SetBool("down_walk", false);
                myAnimator.SetBool("left_walk", false);
                myAnimator.SetBool("right_walk", false);
            }


            if (Input.GetKey(KeyCode.UpArrow))
            {
                myAnimator.SetBool("up", true);
                myAnimator.SetBool("down", false);
                myAnimator.SetBool("right", false);
                myAnimator.SetBool("left", false);
                if (current_key != "UpArrow")
                {
                    myAnimator.SetBool("up_walk", false);
                    myAnimator.SetBool("down_walk", false);
                    myAnimator.SetBool("left_walk", false);
                    myAnimator.SetBool("right_walk", false);
                    counter = 0;
                }
                current_key = "UpArrow";
                counter++;
                if (current_key == "UpArrow" & counter > 1)
                {
                    transform.position += new Vector3(0, 0.2f, 0);
                    myAnimator.SetBool("up", false);
                    myAnimator.SetBool("up_walk", true);
                    myAnimator.SetBool("down_walk", false);
                    myAnimator.SetBool("left_walk", false);
                    myAnimator.SetBool("right_walk", false);
                }
            }



            if (Input.GetKey(KeyCode.DownArrow))
            {
                myAnimator.SetBool("up", false);
                myAnimator.SetBool("down", true);
                myAnimator.SetBool("right", false);
                myAnimator.SetBool("left", false);
                if (current_key != "DownArrow")
                {
                    myAnimator.SetBool("up_walk", false);
                    myAnimator.SetBool("down_walk", false);
                    myAnimator.SetBool("left_walk", false);
                    myAnimator.SetBool("right_walk", false);
                    counter = 0;
                }   
            current_key = "DownArrow";
                counter++;
                if (current_key == "DownArrow" & counter > 1)
                {
                    transform.position += new Vector3(0, -0.2f, 0);
                    myAnimator.SetBool("down", false);
                    myAnimator.SetBool("up_walk", false);
                    myAnimator.SetBool("down_walk", true);
                    myAnimator.SetBool("left_walk", false);
                    myAnimator.SetBool("right_walk", false);
                }
                //transform.position += new Vector3(0, -0.2f, 0);
            }



            if (Input.GetKey(KeyCode.LeftArrow))
            {
                myAnimator.SetBool("up", false);
                myAnimator.SetBool("down", false);
                myAnimator.SetBool("right", false);
                myAnimator.SetBool("left", true);
                if (current_key != "LeftArrow")
                {
                    myAnimator.SetBool("up_walk", false);
                    myAnimator.SetBool("down_walk", false);
                    myAnimator.SetBool("left_walk", false);
                    myAnimator.SetBool("right_walk", false);
                    counter = 0;
                }
            current_key = "LeftArrow";
                counter++;
                if (current_key == "LeftArrow" & counter > 1)
                {
                    transform.position += new Vector3(-0.2f, 0, 0);
                    myAnimator.SetBool("left", false);
                    myAnimator.SetBool("up_walk", false);
                    myAnimator.SetBool("down_walk", false);
                    myAnimator.SetBool("left_walk", true);
                    myAnimator.SetBool("right_walk", false);
                }
                //transform.position += new Vector3(-0.2f, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                myAnimator.SetBool("up", false);
                myAnimator.SetBool("down", false);
                myAnimator.SetBool("right", true);
                myAnimator.SetBool("left", false);
                if (current_key != "RightArrow")
                {
                    myAnimator.SetBool("up_walk", false);
                    myAnimator.SetBool("down_walk", false);
                    myAnimator.SetBool("left_walk", false);
                    myAnimator.SetBool("right_walk", false);
                    counter = 0;
                }
            current_key = "RightArrow";
                counter++;
                if (current_key == "RightArrow" & counter > 1)
                {
                    transform.position += new Vector3(0.2f, 0, 0);
                    myAnimator.SetBool("right", false);
                    myAnimator.SetBool("up_walk", false);
                    myAnimator.SetBool("down_walk", false);
                    myAnimator.SetBool("left_walk", false);
                    myAnimator.SetBool("right_walk", true);
                }
                //transform.position += new Vector3(0.2f, 0, 0);
            }
    }

}

