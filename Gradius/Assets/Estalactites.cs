using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estalactites : MonoBehaviour
{
    public Transform posicaoInicial;
    public GameObject estalactite;
    public Rigidbody2D rb;
    

    public float velocidade = .2f;

    void Start()
    {
        InvocaEstalactite();
    }
    void Update()
    {
        rb.velocity = transform.right * -velocidade;

    }

    void InvocaEstalactite()
    {
        Instantiate(estalactite, posicaoInicial.position, posicaoInicial.rotation);
    }
}
