using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneway : MonoBehaviour
{
    public bool isUp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            transform.parent.GetComponent<Collider2D>().enabled = isUp;
        }
    }
}