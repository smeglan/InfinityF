using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Sector : MonoBehaviour {
    public string nombre;
    [SerializeField]
    public GameObject btn_viaje;
    [SerializeField]
    public GameObject btn_retorno;
    [SerializeField]
    public Text titulo;
    //public float posx;
    //public float posy;
    [SerializeField]
    public GameObject fondo;
    [SerializeField]
    private GameObject sistemas;
    public GameObject galaxia;
    // Use this for initialization

    void Start () {
        nombre = "default";
        //fondo = this.transform.parent.Find("Fondo").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
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

    public void btn_viajar()
    {
        titulo.text = "Sector - " + nombre;
        fondo.SetActive(true);
        sistemas.SetActive(true);
        btn_retorno.SetActive(true);
        btn_retorno.transform.Find("Btn_Viajar").GetComponent<Button>().onClick.RemoveAllListeners();
        btn_retorno.transform.Find("Btn_Viajar").GetComponent<Button>().onClick.AddListener(btn_retornar);
        //btn_viaje.SetActive(false);
    }

    void btn_retornar() {
        titulo.text = "Galaxia - " + galaxia.GetComponent<Galaxia>().nombre;
        fondo.SetActive(false);
        sistemas.SetActive(false);
        btn_retorno.SetActive(false);
    }
}
