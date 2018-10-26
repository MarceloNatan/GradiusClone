using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
   public int Vida = 100;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            //  GetComponent<Rigidbody2D>().AddForce(new Vector3(.8f, 0, 0));
       
               transform.position += new Vector3(.1f, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {

              //  GetComponent<Rigidbody2D>().AddForce(new Vector3(-.8f, 0, 0));

                transform.position -= new Vector3(.1f, 0, 0);
        }

        if (Input.GetAxis("Vertical") > 0.01f)
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector3(0, .8f, 0));

           transform.position += new Vector3(0, 0.1f, 0);
        }
        else if (Input.GetAxis("Vertical") < -0.01f)
        {

            //GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -.8f, 0));

            transform.position -= new Vector3(0, 0.1f, 0);
        }
    }

    public void reduzVida(int vida) {

        this.Vida -= vida;
        if (Vida <= 0) {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //  player pegarVida = collision.transform.GetComponent<player>();
        Debug.Log(collision.transform.name);
        //    pegarVida.reduzVida(50);
        reduzVida(50);
        // Destroy(collision.gameObject);
    }
}
