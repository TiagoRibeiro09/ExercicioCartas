using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogoDeCartas : MonoBehaviour
{
    string[] Cartavs = new string[] { "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10 ", "Valete ", "Dama ", "Rei ", "Ás " };
    string[] CartaSimbolo = new string[] { " Ouro ", " Espadas ", " Copas ", " Paus " };
    string CartaAAparecer1;
    string CartaAAparecer2;

    // Start is called before the first frame update
    void Start()
    {
       Intro();
    }


    private void Intro()
    {
        Debug.Log("Aperte Espaço para sortear uma carta");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string CartaAAparecer1 = Cartavs[Random.Range(0, Cartavs.Length)];
            string CartaAAparecer2 = CartaSimbolo[Random.Range(0, CartaSimbolo.Length)];
            Debug.Log("A carta que te saiu é  " + CartaAAparecer1 + "de" + CartaAAparecer2);
            Intro();
        }

    }
}
  