using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {
    public score value;
    public Rigidbody2D rb;
    public float speed;
    public float height;
    public GameObject pipeup;
    public GameObject pipedown;
    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        BuildLevel();
    }
    void BuildLevel()
    {
        Instantiate(pipedown, new Vector3(3,4), transform.rotation);
        Instantiate(pipeup, new Vector3(3, -4), transform.rotation);

        Instantiate(pipedown, new Vector3(8, 5), transform.rotation);
        Instantiate(pipeup, new Vector3(8, -3), transform.rotation);

        Instantiate(pipedown, new Vector3(13, 2), transform.rotation);
        Instantiate(pipeup, new Vector3(13, -6), transform.rotation);

        Instantiate(pipedown, new Vector3(18, 3), transform.rotation);
        Instantiate(pipeup, new Vector3(18, -5), transform.rotation);

        Instantiate(pipedown, new Vector3(23, 6), transform.rotation);
        Instantiate(pipeup, new Vector3(23, -2), transform.rotation);

        Instantiate(pipedown, new Vector3(28, 6), transform.rotation);
        Instantiate(pipeup, new Vector3(28, -2), transform.rotation);

        Instantiate(pipedown, new Vector3(33, 2), transform.rotation);
        Instantiate(pipeup, new Vector3(33, -6), transform.rotation);

        Instantiate(pipedown, new Vector3(38, 6), transform.rotation);
        Instantiate(pipeup, new Vector3(38, -2), transform.rotation);

        Instantiate(pipedown, new Vector3(43, 6), transform.rotation);
        Instantiate(pipeup, new Vector3(43, -2), transform.rotation);
        

        
       
    }

    // Update is called once per frame
    void Update() {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, height);
            score.value += 10;
        }
        if (transform.position.y > 10|| transform.position.y<-10)
        {
            death();
        }

	}
    public void death()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
        score.value = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "lol")
        {
            death();
       
        }
    }

}
