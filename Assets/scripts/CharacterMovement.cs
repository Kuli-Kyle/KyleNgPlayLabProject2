using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Vector3 leftmoveforce;
    public Vector3 rightmoveforce;
    public Vector3 jumpforce;
    public bool canJump;
    public GameObject leftbulletprefab;
    public GameObject rightbulletprefab;
    public int playerFacing;


    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(playerFacing == 1)
            {
                Instantiate(rightbulletprefab, GetComponent<Transform>().position, Quaternion.identity);
            }

            if(playerFacing == -1)
            {
                Instantiate(leftbulletprefab, GetComponent<Transform>().position, Quaternion.identity);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerFacing = 1;
            GetComponent<Rigidbody2D>().AddForce(rightmoveforce);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerFacing = -1;
            GetComponent<Rigidbody2D>().AddForce(leftmoveforce);
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (canJump == true)
            {
                canJump = false;
                GetComponent<Rigidbody2D>().AddForce(jumpforce);

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true; 
    }
}
