using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstadoMensaje : MonoBehaviour
{
    public GameObject[] cajaRespuesta;
    public Text[] textoRespuestas;

    public Maquina maquina;
    public EstadoRespuesta respuesta;

    public GameObject sonidoBoton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        cajaRespuesta[respuesta.indice - 1].SetActive(true);
        respuesta.botones[0].SetActive(false);
        respuesta.botones[1].SetActive(false);
        respuesta.botones[2].SetActive(false);
        StartCoroutine(Delay1());
    }

    public void Mensaje1()
    {
        maquina.ActivarEstado(maquina.EstadoMesaje);
        textoRespuestas[respuesta.indice - 1].text = respuesta.textoRespuesta[0].text;
        sonidoBoton.SetActive(true);
    }
    public void Mensaje2()
    {
        maquina.ActivarEstado(maquina.EstadoMesaje);
        textoRespuestas[respuesta.indice - 1].text = respuesta.textoRespuesta[1].text;
        sonidoBoton.SetActive(true);
    }
    public void Mensaje3()
    {
        maquina.ActivarEstado(maquina.EstadoMesaje);
        textoRespuestas[respuesta.indice - 1].text = respuesta.textoRespuesta[2].text;
        sonidoBoton.SetActive(true);
    }

    public IEnumerator Delay1()
    {
        yield return new WaitForSeconds(2);
        maquina.ActivarEstado(maquina.EstadoEsperar);
    }
}
