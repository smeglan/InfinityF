using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GalaxyCreator : MonoBehaviour {

    [SerializeField]
    private GameObject sector;
    [SerializeField]
    private GameObject vistaCreador;
    [SerializeField]
    private GameObject btn_viaje;
    [SerializeField]
    private GameObject btn_retorno;
    [SerializeField]
    private Text titulo;
    [SerializeField]
    private Vector3 mouse;

    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject()&&this.GetComponent<GalaxyCreator>().isActiveAndEnabled)
        {
            vistaCreador.SetActive(true);
            mouse = Input.mousePosition;
            mouse = Camera.main.ScreenToWorldPoint(mouse);
            mouse.z += 10;
            vistaCreador.transform.Find("ButtonCrear").GetComponent<Button>().onClick.RemoveAllListeners();
            vistaCreador.transform.Find("ButtonCrear").GetComponent<Button>().onClick.AddListener(crearSector);
            print(mouse);
        }
    }
    void crearSector()
    {
        string nombre = vistaCreador.transform.Find("Nombre").GetComponent<InputField>().text;
        sector.transform.Find("ImgSector").GetComponent<Sector>().nombre = nombre;
        sector.transform.Find("ImgSector").GetComponent<Sector>().btn_viaje = btn_viaje;
        sector.transform.Find("ImgSector").GetComponent<Sector>().btn_retorno = btn_retorno;
        sector.transform.Find("ImgSector").GetComponent<Sector>().titulo = titulo;
        sector.transform.Find("ImgSector").GetComponent<Sector>().galaxia = this.gameObject;
        sector.transform.Find("ImgSector").transform.Translate(mouse);
        sector.transform.Find("ImgSector").GetComponent<Sector>().btn_viajar();
        GameObject _newsector = Instantiate(sector, sector.transform.position, sector.transform.rotation);
        _newsector.transform.SetParent(this.transform.parent.Find("Sectores").transform, true);
        vistaCreador.transform.Find("Nombre").GetComponent<InputField>().text = "";
        vistaCreador.SetActive(false);
        //GameObject _newsector = Instantiate(sector, mouse, sector.transform.rotation);
    }

}
