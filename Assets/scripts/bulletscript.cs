using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{

    public Vector3 bulletmove;
    public float bullettimer;
    public GameObject leftbullet;
    public GameObject rightbullet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += bulletmove;

        bullettimer += Time.deltaTime;
        if(bullettimer > 1f)
        {
            Destroy(gameObject);
        }


    }
}
