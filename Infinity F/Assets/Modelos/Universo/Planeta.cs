using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planeta : MonoBehaviour {
    [SerializeField]
    private string nombre;
    private int x;
    private int y;
    private int iridio;
    private int platino;
    private int paladio;
    private int elementoZero;
    [SerializeField]
    private int tipo;
    [SerializeField]
    private GameObject ventana_datos;
    [SerializeField]
    private Text txt_nombre;
    [SerializeField]
    private Text txt_iridio;
    [SerializeField]
    private Text txt_platino;
    [SerializeField]
    private Text txt_paladio;
    [SerializeField]
    private Text txt_elementoZero;
    [SerializeField]
    private Sprite[] img_planetas;

    public Planeta(string nombre, int x, int y, int tipo, int iridio, int platino, int paladio, int elementoZero)
    {
        this.nombre = nombre;
        this.x = x;
        this.y = y;
        this.tipo = tipo;
        this.iridio = iridio;
        this.platino = platino;
        this.paladio = paladio;
        this.elementoZero = elementoZero;
    }
    // Use this for initialization
    void Start() {
        this.nombre = "default";
        this.iridio = 0;
        this.platino = 0;
        this.paladio = 0;
        this.elementoZero = 0;
        //img_planetas = new Sprite[7];
    }

    // Update is called once per frame
    void Update() {
        this.transform.Find("ImgPlaneta").GetComponent<SpriteRenderer>().sprite = img_planetas[tipo];
    }

    void OnMouseDown() {
        ventana_datos.SetActive(true);
        txt_nombre.text = "Planeta: "+ nombre;
        txt_iridio.text = "Iridio: " + iridio;
        txt_platino.text = "platino: " + platino;
        txt_paladio.text = "Paladio: " + paladio;
        txt_elementoZero.text = "Elemento Zero: " + elementoZero;
    }

}
