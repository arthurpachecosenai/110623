using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ComandosBasicos : MonoBehaviour
{
    public int velocidade;
    private Rigidbody2D rbPlayer;
    public float forcaPulo;

    public Tool sensor;

  
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoX = Input.GetAxisRaw("Horizontal");

        rbPlayer.velocity = new Vector2(movimentoX * velocidade, rbPlayer.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rbPlayer.AddForce(new Vector2(0, forcaPulo));
        }
    }
}
