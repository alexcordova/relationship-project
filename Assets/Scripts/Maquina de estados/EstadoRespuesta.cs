using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NeuralNetwork;

public class EstadoRespuesta : MonoBehaviour
{
    NeuralNetwork.NeuralNet net;
    List<DataSet> dataSets;

    public GameObject[] cajasMensaje;
    public Text[] textoMensaje;
    public Text[] textoRespuesta;
    public int indice;
    public GameObject[] botones;
    public GameObject sonidoNotificacion;

    public Maquina maquina;

    public int col;
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
        net = new NeuralNet(3, 1, 1);
        dataSets = new List<DataSet>();
        Debug.Log("inicializando");

        double[] inputs = new double[3];
        double[] desireOutputs = new double[1];
        inputs[0] = 0.1f;
        inputs[1] = 0.1f;
        inputs[2] = 0.1f;

        desireOutputs[0] = 0.1f;
        dataSets.Add(new DataSet(inputs, desireOutputs));

        net.Train(dataSets, 0.001f);

        double[] vals = new double[3];
        vals[0] = 0.1f;
        vals[1] = 0.1f;
        vals[2] = 0.9f;
        double[] respuesta = net.Compute(vals);
        Debug.Log(respuesta[0]);

        if(respuesta[0] < 0.09f)
        {
            col = 0;
        }
        if (respuesta[0] > 0.09f && respuesta[0] < 0.1)
        {
            col = 1;
        }
        if (respuesta[0] > 0.1f)
        {
            col = 2;
        }

        sonidoNotificacion.SetActive(true);
        indice++;
        botones[0].SetActive(true);
        botones[1].SetActive(true);
        botones[2].SetActive(true);
        cajasMensaje[indice - 1].SetActive(true);
        textoMensaje[indice - 1].text = maquina.mensajesMaquina[indice - 1, col];
        textoRespuesta[0].text = maquina.mensajesUsuario[indice - 1, 0];
        textoRespuesta[1].text = maquina.mensajesUsuario[indice - 1, 1];
        textoRespuesta[2].text = maquina.mensajesUsuario[indice - 1, 2];
        if(indice == 6)
        {
            maquina.ActivarEstado(maquina.EstadoCaptura);
        }
    }
}
