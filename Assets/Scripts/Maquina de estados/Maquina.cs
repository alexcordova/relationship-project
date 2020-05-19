using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maquina : MonoBehaviour
{
    public MonoBehaviour EstadoEsperar;
    public MonoBehaviour EstadoRespuesta;
    public MonoBehaviour EstadoCaptura;
    public MonoBehaviour EstadoMesaje;
    public MonoBehaviour EstadoInicial;

    private MonoBehaviour estadoActual;

    public string[,] mensajesMaquina = new string[6,10];
    public string[,] mensajesUsuario = new string[6, 9];

    //public bool acabo;
    // Start is called before the first frame update
    void Start()
    {
        ActivarEstado(EstadoInicial);

        mensajesMaquina[0, 0] = "Hola";
        mensajesMaquina[0, 1] = "Hi";
        mensajesMaquina[0, 2] = "Hola!!!";
        mensajesMaquina[1, 0] = "Ya vi lo de FB";
        mensajesMaquina[1, 1] = "Ya vi lo de IG";
        mensajesMaquina[1, 2] = "Ya vi lo que pusiste";
        mensajesMaquina[2, 0] = "Claro, hazte wey!";
        mensajesMaquina[2, 1] = "No me mientas";
        mensajesMaquina[2, 2] = ">:v";
        mensajesMaquina[3, 0] = "Ya me cance";
        mensajesMaquina[3, 1] = "Siempre es lo mismo";
        mensajesMaquina[3, 2] = "No vas acambiar";
        mensajesMaquina[4, 0] = "Ves como eres";
        mensajesMaquina[4, 1] = "T.T";
        mensajesMaquina[4, 2] = ":'v";
        mensajesMaquina[5, 0] = "Bye";
        mensajesMaquina[5, 1] = "Ya adios";
        mensajesMaquina[5, 2] = "Adios";

        mensajesUsuario[0, 0] = "Hola!";
        mensajesUsuario[0, 1] = ":v";
        mensajesUsuario[0, 2] = "Qué pasa?";
        mensajesUsuario[1, 0] = "De qué hablas?";
        mensajesUsuario[1, 1] = "No fui yo";
        mensajesUsuario[1, 2] = "Agarraron mi celular";
        mensajesUsuario[2, 0] = "No lo vuelvo a hacer";
        mensajesUsuario[2, 1] = "Me perdonas?";
        mensajesUsuario[2, 2] = "Upssss...";
        mensajesUsuario[3, 0] = "Ya vas a empezar";
        mensajesUsuario[3, 1] = "Yaaaaaa";
        mensajesUsuario[3, 2] = "Dale con la misma";
        mensajesUsuario[4, 0] = "No llores";
        mensajesUsuario[4, 1] = "Ya tranquilizate";
        mensajesUsuario[4, 2] = ":v";
    }

    public void ActivarEstado(MonoBehaviour nuevoEstado)
    {
        if(estadoActual != null)
            estadoActual.enabled = false;
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
