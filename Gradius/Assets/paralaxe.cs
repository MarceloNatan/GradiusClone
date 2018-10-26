using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralaxe : MonoBehaviour {

    public float scrollspeed;
    public float tamanhoDoTile;
    Vector3 posicaoInicial;
    Vector3 posicaoInicia2;
    // Use this for initialization
    void Start () {
        posicaoInicial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float novaposicao = Mathf.Repeat(Time.time * scrollspeed, tamanhoDoTile);
        transform.position = posicaoInicial + Vector3.left * novaposicao;
	}
}
    