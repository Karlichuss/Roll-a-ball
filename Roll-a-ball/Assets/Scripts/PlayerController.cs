///////////////////////////////
// Practica: Roll-a-ball
// Alumno: Antonio Carlos Ordoñez Cintrano
// Curso: 2017/2018
// Fichero: PlayerController.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controlador del GameObject Player.
/// </summary>
public class PlayerController : MonoBehaviour {

    #region Declaracion de variables

    /// <summary>
    /// Multiplicador de velocidad de la esfera.
    /// </summary>
    public float speed;
    /// <summary>
    /// GameObject de texto que indica la puntuación.
    /// </summary>
    public Text countText;
    /// <summary>
    /// GameObject de texto que felicita al jugador.
    /// </summary>
    public Text winText;
    /// <summary>
    /// Componente del GameObject para manejas las fisicas.
    /// </summary>
    private Rigidbody rb;
    /// <summary>
    /// La puntuacion actual.
    /// </summary>
    private int count;

    #endregion

    #region Metodos

    /// <summary>
    /// Metodo que es llamado nada mas inicar el juego.
    /// </summary>
    void Start()
    {
        /// Asignamos el componente Rigidbody del GameObject.
        rb = GetComponent<Rigidbody>();
        /// Ponemos el contador a cero.
        count = 0;
        /// Ponemos la puntuacion en pantalla.
        SetCountText();
    }

    /// <summary>
    /// Metodo Update() especifico para el Rigidbody.
    /// </summary>
    void FixedUpdate()
    {
        /// Asignamos el valor del control Izquierda/Derecha.
        float moveHorizontal = Input.GetAxis("Horizontal");
        /// Asignamos el valor del control Arriba/Abajo.
        float moveVertical = Input.GetAxis("Vertical");
        /// Aplicamos una fuerza a la direccion de los controles segun el valor de speed.
        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical)*speed);
    }

    /// <summary>
    /// Metodo que es llamado cada vez que el jugador interactua (colisiona con la hitbox) de otro GameObject que tenga algun componente de tipo Collider.
    /// </summary>
    /// <param name="other">El componente Collider del Gameobject con el que colisiona.</param>
    void OnTriggerEnter(Collider other)
    {
        /// Comprobamos que el GameObject con el que colisiona tenga la tag "PickUp".
        if (other.gameObject.CompareTag("PickUp"))
        {
            /// Deshabilitamos el GameOBject.
            other.gameObject.SetActive(false);
            /// Ganamos un punto.
            count++;
            /// Actualizamos la puntuacion en pantalla.
            SetCountText();
        }
    }

    /// <summary>
    /// Metodo que actualiza la puntuacion que mostramos en pantalla con la puntuacion actual.
    /// </summary>
    void SetCountText()
    {
        /// Actualizamos el GameObject countText con la puntuacion actual.
        countText.text = string.Format("Count: {0}", count);
        /// Y si la puntuacion actual es de 6 (Puntuacion maxima).
        if (count == 6)
        {
            /// Felicitamos al jugador con un Game Over.
            winText.text = "Game Over";
        }
    }

    #endregion
}
