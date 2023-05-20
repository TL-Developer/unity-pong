using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum EPositoinLimiteHorizontal
{
    esquerda,
    direita1
}

public class BolaController : MonoBehaviour
{

    public Rigidbody2D meuRigiBody;
    private Vector2 minhaVelocidade;
    public float velocidade = 5f;
    public float limiteHorizontal = 12f;
    public AudioClip audioClip;
    public Transform transformCamera;
    public float delay = 2f;
    public bool jogoIniciado = false;

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

    void resetGame()
    {
        if (transform.position.x > limiteHorizontal || transform.position.x < -limiteHorizontal)
        {
            SceneManager.LoadScene("Jogo");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;

        if (delay <= 0 && !jogoIniciado)
        {
            jogoIniciado = true;

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

        resetGame();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(audioClip, transformCamera.position);
    }
}
