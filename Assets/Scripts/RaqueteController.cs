using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    public float meuY;

    void Start()
    {
        minhaPosicao.x = transform.position.x;
    }

    void Update()
    {
        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;
    }
}
