using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispMovement : MonoBehaviour
{
    Rigidbody2D rb;

    //[SerializeField] float x;
    //[SerializeField] float y;

    [SerializeField] float amplitude;
    [SerializeField] float freq;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(Time.time * freq) * amplitude;
        float y = Mathf.Cos(Time.time * freq) * amplitude;
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(x, y);
        transform.position =  new Vector2(x + this.transform.position.x, y + this.transform.position.y);

        //rb.velocity = new Vector2(Mathf.Sin(Mathf.Lerp(min, max, 0.25f)), Mathf.Cos(Mathf.Lerp(min, max, 0.25f)));
    }
}
