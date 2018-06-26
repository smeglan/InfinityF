using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Sistema : MonoBehaviour {

    [SerializeField]
    string nombre;
    [SerializeField]
    GameObject btn_viaje;
    [SerializeField]
    GameObject btn_retorno;
    [SerializeField]
    Text titulo;
    [SerializeField]
    GameObject estrella;
    [SerializeField]
    GameObject fondo;
    [SerializeField]
    GameObject planetas;
    [SerializeField]
    GameObject sector;
    

    // Use this for initialization
    void Start () {
        nombre = "default";
        //fondo = this.transform.Find("Fondo").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        fondo.SetActive(false);
	}
    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            btn_viaje.SetActive(true);
            btn_viaje.transform.Find("Btn_Viajar").GetComponent<Button>().onClick.RemoveAllListeners();
            btn_viaje.transform.Find("Btn_Viajar").GetComponent<Button>().onClick.AddListener(btn_viajar);
        }
    }

    public void btn_viajar() {
        titulo.text = "Sistema - " + nombre;
        estrella.SetActive(true);
        fondo.SetActive(true);
        planetas.SetActive(true);
        btn_retorno.SetActive(true);
        btn_retorno.transform.Find("Btn_Viajar").GetComponent<Button>().onClick.RemoveAllListeners();
        btn_retorno.transform.Find("Btn_Viajar").GetComponent<Button>().onClick.AddListener(btn_retornar);
        if (btn_viaje.activeSelf)
        {
            print("aqui");
            btn_viaje.SetActive(false);
        }
    }
    void btn_retornar()
    {
        titulo.text = "Sector - " + sector.GetComponent<Sector>().nombre;
        fondo.SetActive(false);
        planetas.SetActive(false);
        btn_retorno.SetActive(false);
    }

}
