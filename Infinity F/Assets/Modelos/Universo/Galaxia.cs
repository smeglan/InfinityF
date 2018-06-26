using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Galaxia : MonoBehaviour
{

    // Use this for 
    public string nombre;
    public bool flag_editor;
    [SerializeField]
    private GameObject sector;
    [SerializeField]
    private Vector3 mouse;
    //Interfaz
    [SerializeField]
    private GameObject vista_creador;
    [SerializeField]
    private GameObject btn_retorno;
    [SerializeField]
    GameObject btn_viaje;
    [SerializeField]
    Text titulo;

    void Start()
    {
        titulo.text = "Galaxia - " + nombre;
    }

    void creador() {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            titulo.text = "Galaxia - " + nombre;
            btn_viaje.SetActive(false);
        }
        if (!EventSystem.current.IsPointerOverGameObject() && flag_editor)
        {
            vista_creador.SetActive(true);
            mouse = Input.mousePosition;
            mouse = Camera.main.ScreenToWorldPoint(mouse);
            mouse.z += 10;
            vista_creador.transform.Find("ButtonCrear").GetComponent<Button>().onClick.RemoveAllListeners();
            vista_creador.transform.Find("ButtonCrear").GetComponent<Button>().onClick.AddListener(crearSector);
            print(mouse);
        }
    }

    
    void crearSector()
    {
        string nombre = vista_creador.transform.Find("Nombre").GetComponent<InputField>().text;
        sector.transform.Find("ImgSector").GetComponent<Sector>().nombre = nombre;
        sector.transform.Find("ImgSector").GetComponent<Sector>().btn_viaje = btn_viaje;
        sector.transform.Find("ImgSector").GetComponent<Sector>().btn_retorno = btn_retorno;
        sector.transform.Find("ImgSector").GetComponent<Sector>().titulo = titulo;
        sector.transform.Find("ImgSector").GetComponent<Sector>().galaxia = this.gameObject;
        sector.transform.Find("ImgSector").transform.Translate(mouse);
        sector.transform.Find("ImgSector").GetComponent<Sector>().btn_viajar();
        GameObject _newsector = Instantiate(sector, sector.transform.position, sector.transform.rotation);
        _newsector.transform.SetParent(this.transform.parent.Find("Sectores").transform, true);
        vista_creador.transform.Find("Nombre").GetComponent<InputField>().text = "";
        vista_creador.SetActive(false);
        //GameObject _newsector = Instantiate(sector, mouse, sector.transform.rotation);
    }

}