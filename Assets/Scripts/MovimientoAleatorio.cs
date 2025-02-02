using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, Random.Range(0f, 360f));
        rb.AddForce(new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f))  * speed);
    }
}
