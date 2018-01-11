///////////////////////////////
// Practica: Roll-a-ball
// Alumno: Antonio Carlos Ordoñez Cintrano
// Curso: 2017/2018
// Fichero: Rotator.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script que hace la animacion de girar a los PickUps.
/// </summary>
public class Rotator : MonoBehaviour {

    #region Metodos

    /// <summary>
    /// Metodo llamado una vez por cada frame.
    /// </summary>
    void Update () {
        /// Giramos al GameObject 12 grados hacia la izquierda, 30 grados hacia arriba y 45 grados hacia atras, multiplicado por el tiempo en segundos que ha pasado desde el anterior frame.
        transform.Rotate(new Vector3(12, 30, 45) * Time.deltaTime);
	}

    #endregion
}
