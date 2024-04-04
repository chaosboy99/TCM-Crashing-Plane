using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{ 
    [SerializeField] private float cantidadPuntos;

    [SerializeField] private Puntos puntos;
    
    private void OntriggerEnter2D(Collider2D other)
    {
            puntos.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
    }


}
