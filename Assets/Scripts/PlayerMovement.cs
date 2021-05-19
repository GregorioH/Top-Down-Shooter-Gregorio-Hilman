using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public float velocidadMovimiento = 5f;

	public Rigidbody2D rb;
    public Camera camara;

    Vector2 movimiento;
    Vector2 posicionMouse;

	void Update () 
	{
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");

        posicionMouse = camara.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidadMovimiento * Time.fixedDeltaTime);

        Vector2 apuntar = posicionMouse - rb.position;
        float angulo = Mathf.Atan2(apuntar.y, apuntar.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angulo;
    }
}
