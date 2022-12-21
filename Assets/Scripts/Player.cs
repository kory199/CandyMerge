using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    float limitLeft = -3;
    float limitRight = 3;
    float firstY = 3.8f;
    public bool flag = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.Sleep();
    }


    void Update()
    {
        Vector2 mPosition = Input.mousePosition;
        Vector2 target = Camera.main.ScreenToWorldPoint(mPosition);

        //this.transform.position = new Vector2(target.x, 4);

        if (flag == false)
        {
            this.transform.position = new Vector2(target.x, 4);

                if (transform.position.y >= firstY)
                {
                    if (transform.position.x <= limitLeft)
                    {
                        transform.position = new Vector2(-3, 4);
                    }

                    if (transform.position.x >= limitRight)
                    {
                        transform.position = new Vector2(3, 4);
                    }
                }
            

        }
        if (Input.GetMouseButtonDown(0))
        {
            flag = true;
            rb.WakeUp();
        }
    }
}
