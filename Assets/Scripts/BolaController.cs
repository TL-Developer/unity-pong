using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{

    public Rigidbody2D meuRigiBody;
    private Vector2 minhaVelocidade;
    public float velocidade = 5f;

    void superiorEsquerdo()
    {
        minhaVelocidade.y = velocidade;
        minhaVelocidade.x = -velocidade;
    }

    void superiorDireito()
    {
        minhaVelocidade.y = velocidade;
        minhaVelocidade.x = velocidade;
    }

    void inferiorDireito()
    {
        minhaVelocidade.y = -velocidade;
        minhaVelocidade.x = velocidade;
    }

    void inferiorEsquerdo()
    {
        minhaVelocidade.y = -velocidade;
        minhaVelocidade.x = -velocidade;
    }

    // Start is called before the first frame update
    void Start()
    {
        minhaVelocidade.x = -velocidade;

        int random = Random.Range(0, 3);

        if (random == 0)
        {
            superiorEsquerdo();
        }
        else if (random == 1)
        {
            superiorDireito();
        }
        else if (random == 3)
        {
            inferiorEsquerdo();
        }
        else
        {
            inferiorDireito();
        }

        meuRigiBody.velocity = minhaVelocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
