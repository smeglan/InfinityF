using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planeta : MonoBehaviour {

    [SerializeField]
    private string nombre;
    private float x;
    private float y;
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

    public void crearPlaneta(string nombre, float x, float y, int tipo, int iridio, int platino, int paladio, int elementoZero, GameObject ventana)
    {
        this.nombre = nombre;
        this.x = x;
        this.y = y;
        this.tipo = tipo;
        this.iridio = iridio;
        this.platino = platino;
        this.paladio = paladio;
        this.elementoZero = elementoZero;
        transform.Find("ImgPlaneta").GetComponent<SpriteRenderer>().sprite = img_planetas[tipo];
        ventana_datos = ventana;
    }
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
            
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Nave")) {
            ventana_datos.SetActive(true);
            ventana_datos.transform.Find("Nombre").GetComponent<Text>().text = "Planeta: " + nombre;
            ventana_datos.transform.Find("Iridio").GetComponent<Text>().text = "Iridio: " + iridio;
            ventana_datos.transform.Find("Platino").GetComponent<Text>().text = "Platino: " + platino;
            ventana_datos.transform.Find("Paladio").GetComponent<Text>().text = "Paladio: " + paladio;
            ventana_datos.transform.Find("Zero").GetComponent<Text>().text = "Elemento Zero: " + elementoZero;
        }
    }
}
