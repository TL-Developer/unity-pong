using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    private float meuY;
    public float velocidade = 5f;
    public float limiteTela = 3.8f;
    public int player;

    RaqueteController()
    {
        
    }

    void Start()
    {
        minhaPosicao = transform.position;
    }

    void handleCima(KeyCode keyCode)
    {
        if (Input.GetKey(keyCode) && meuY < limiteTela)
        {
            meuY += velocidade * Time.deltaTime;
        }
    }

    void handleBaixo(KeyCode keyCode)
    {
        if (Input.GetKey(keyCode) && meuY > -limiteTela)
        {
            meuY -= velocidade * Time.deltaTime;
        }
    }

    void Update()
    {
        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;

        if (player == 1)
        {
            handleCima(KeyCode.UpArrow);
            handleBaixo(KeyCode.DownArrow);
        } else
        {
            handleCima(KeyCode.W);
            handleBaixo(KeyCode.S);
        }
    }
}
