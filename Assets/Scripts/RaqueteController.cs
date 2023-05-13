using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    public float meuY;
    private float velocidade;
    private float limiteTela = 3.8f;

    RaqueteController()
    {
        
    }

    void Start()
    {
        velocidade = 0.5f * Time.deltaTime;
        minhaPosicao.x = transform.position.x;
    }

    void Update()
    {
        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;

        if (Input.GetKey(KeyCode.UpArrow) && meuY < limiteTela)
        {
            meuY += velocidade;
        }

        if (Input.GetKey(KeyCode.DownArrow) && meuY > -limiteTela)
        {
            meuY -= velocidade;
        }
    }
}
