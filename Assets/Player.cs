using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    private Rigidbody2D bonecoFisica;

    public Text Pontos;
    public int score = 0;

    [SerializeField]
    private float horizontalMove = 0f;
    float movementSpeed = 10f;

    [SerializeField]
    private float JumpForce = 3f;

    void Start()
    {
        bonecoFisica = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Andar();
        Pular();
    }

    private void Andar()
    {
        horizontalMove = (Input.GetAxisRaw("Horizontal"));
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * movementSpeed;
    }

    private void Pular()
    {
        if (Input.GetButtonDown("Jump"))
        {
            bonecoFisica.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
