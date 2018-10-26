using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

    public float scrollspeed;
    public float tamanhoDoTile;
    Vector3 posicaoInicial;
    public int vida = 100;
    public GameObject Player;
    void Start()
    {
        posicaoInicial = transform.position;
        Player = gameObject.GetComponent<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        float novaposicao = Mathf.Repeat(Time.time * scrollspeed, tamanhoDoTile);
        transform.position = posicaoInicial + Vector3.left * novaposicao;
        if (vida < 0 )
        {
            Destroy(this.gameObject);
        }

    }


    public void TomaDano(int dano)
    {
        vida -= dano;
    }

    
}
