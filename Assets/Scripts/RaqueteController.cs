using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    private float meuY;
    public float velocidade = 5f;
    public float limiteTela = 3.38f;
    public int player;
    public bool automatico = false;
    public Transform transformBola;

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

    void resetMeuLimite()
    {
        if (meuY < -limiteTela)
        {
            meuY = -limiteTela;
        }

        if (meuY > limiteTela)
        {
            meuY = limiteTela;
        }
    }

    void Update()
    {
        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;

        if (!automatico)
        {
            if (player == 1)
            {
                
                handleCima(KeyCode.W);
                handleBaixo(KeyCode.S);
            }
            else
            {
                handleCima(KeyCode.UpArrow);
                handleBaixo(KeyCode.DownArrow);
            }
        } else
        {
            meuY = Mathf.Lerp(meuY, transformBola.position.y, 0.02f);
        }

        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            automatico = false;
        }

        if (Input.GetKey(KeyCode.Return))
        {
            automatico = true;
        }

        resetMeuLimite();
    }
}
