using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform pontoLaser;
    public int dano = 10;
    public GameObject explosao;
    public LineRenderer linha;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           
            StartCoroutine(Disparar());
        }

    }

    IEnumerator Disparar()
    {

        RaycastHit2D hitInfo = Physics2D.Raycast(pontoLaser.position, pontoLaser.right);

        if (hitInfo)
        {
            Debug.Log(hitInfo.transform.name);

            Inimigo inimigo = hitInfo.transform.GetComponent<Inimigo>();

            if (inimigo != null)
            {
                GameObject explode = Instantiate(explosao, hitInfo.point, Quaternion.identity) as GameObject;
                Destroy(explode, 1.0f);
                inimigo.TomaDano(dano);
            }
            linha.SetPosition(0, pontoLaser.position);
            linha.SetPosition(1, hitInfo.point);
        }
        else
        {
            linha.SetPosition(0, pontoLaser.position);
            linha.SetPosition(1, pontoLaser.position + pontoLaser.right * 100);
        }

        linha.enabled = true;
        yield return 0;
        linha.enabled = false;
    }
}
