using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstadoCaptura : MonoBehaviour
{
    public EstadoRespuesta respuesta;
    public GameObject final;
    public Text textoFinal;
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
        respuesta.botones[0].SetActive(false);
        respuesta.botones[1].SetActive(false);
        respuesta.botones[2].SetActive(false);
        final.SetActive(true);
    }
}
