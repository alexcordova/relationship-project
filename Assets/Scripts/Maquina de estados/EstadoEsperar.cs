using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoEsperar : MonoBehaviour
{
    public Maquina maquina;
    public EstadoRespuesta respuesta;
    public EstadoMensaje mensaje;

    private void OnEnable()
    {
        StartCoroutine(Delay());
        respuesta.sonidoNotificacion.SetActive(false);
        mensaje.sonidoBoton.SetActive(false);
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
        maquina.ActivarEstado(maquina.EstadoRespuesta);
    }
}
