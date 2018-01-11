///////////////////////////////
// Practica: Roll-a-ball
// Alumno: Antonio Carlos Ordoñez Cintrano
// Curso: 2017/2018
// Fichero: CameraController.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controlador del GameObject Main Camera
/// </summary>
public class CameraController : MonoBehaviour {
    
    #region Declaracion de variables

    /// <summary>
    /// GameObject Player al que vamos a tomar como referencia.
    /// </summary>
    public GameObject player;
    /// <summary>
    /// Desfase de la posicion del GameObject a la de Player.
    /// </summary>
    private Vector3 offset;

    #endregion

    #region Metodos
    /// <summary>
    /// Metodo que es llamado nada mas iniciar el juego.
    /// </summary>
    void Start()
    {
        /// Restamos a la posicion de la camara la del jugador.
        offset = transform.position - player.transform.position;
    }

    /// <summary>
    /// Metodo llamado despues de actualizar los datos en cada frame.
    /// </summary>
    void LateUpdate()
    {
        /// El frame ha refrescado la posicion del jugador. Ahora con esta nueva posicion vamos a situar la camara en su posicion equivalente segun el desfase calculado.
        transform.position = player.transform.position + offset;
    }

    #endregion
}
