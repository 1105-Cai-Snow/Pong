using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {


    }



    public void Reset(int direction){
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch(direction);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            startPosition = transform.position;
            Launch(1);
        }
    }
    private void Launch(int direction){

        float x = direction == -1 ? -1:1;
        float y = Random.Range(0,2) == 0? -1:1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
