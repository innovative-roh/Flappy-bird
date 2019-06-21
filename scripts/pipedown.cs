using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipedown : MonoBehaviour
{
    private character character;
    
    // Use this for initialization
    void Start()
    {
        character = FindObjectOfType<character>();
    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 30)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            character.death();
        }
    }
}

