using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CrearPlaneta : MonoBehaviour {

    [SerializeField]
    private GameObject creador;
    [SerializeField]
    private GameObject ventana_estado_planetas;
    [SerializeField]
    private GameObject planet;
    //World
    private Vector3 ubicacion;
    Vector2 mousePos = new Vector2();
    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            print(Input.mousePosition);
            mousePos.x = Input.mousePosition.x;
            mousePos.y = Input.mousePosition.y;
            ubicacion = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y));
            ubicacion.z = -1f;
            creador.SetActive(true);
            creador.transform.Find("Botones").Find("ButtonCrear").GetComponent<Button>().onClick.RemoveAllListeners();
            creador.transform.Find("Botones").Find("ButtonCrear").GetComponent<Button>().onClick.AddListener(crearPlaneta);
            creador.transform.Find("Botones").Find("ButtonRandom").GetComponent<Button>().onClick.RemoveAllListeners();
            creador.transform.Find("Botones").Find("ButtonRandom").GetComponent<Button>().onClick.AddListener(iniRandom);
        }
    }
    void crearPlaneta()
    {
        print(creador.transform.Find("Botones").Find("Dropdown").GetComponent<Dropdown>().value);
        GameObject _newplanet = Instantiate(planet, planet.transform.position, planet.transform.rotation);
        _newplanet.GetComponent<Planeta>().crearPlaneta((transform.parent.GetComponent<Sistema>().name + transform.parent.GetComponents<Planeta>().Length + 1),
            ubicacion.x, ubicacion.y, creador.transform.Find("Botones").Find("Dropdown").GetComponent<Dropdown>().value,
            (int)creador.transform.Find("Panel_Recursos").Find("Panel_Iridio").Find("Slider").GetComponent<Slider>().value,
            (int)creador.transform.Find("Panel_Recursos").Find("Panel_Paladio").Find("Slider").GetComponent<Slider>().value,
            (int)creador.transform.Find("Panel_Recursos").Find("Panel_Platino").Find("Slider").GetComponent<Slider>().value,
            (int)creador.transform.Find("Panel_Recursos").Find("Panel_Zero").Find("Slider").GetComponent<Slider>().value,
            ventana_estado_planetas);
        _newplanet.transform.position=ubicacion;
        _newplanet.transform.SetParent(this.transform.parent.Find("Planetas").transform, true);
        creador.SetActive(false);
    }

    void iniRandom()
    {
        creador.transform.Find("Panel_Recursos").Find("Panel_Iridio").Find("Slider").GetComponent<Slider>().value = (int)Random.Range(0, 5000);
        creador.transform.Find("Panel_Recursos").Find("Panel_Paladio").Find("Slider").GetComponent<Slider>().value = (int)Random.Range(0, 5000);
        creador.transform.Find("Panel_Recursos").Find("Panel_Platino").Find("Slider").GetComponent<Slider>().value = (int)Random.Range(0, 5000);
        creador.transform.Find("Panel_Recursos").Find("Panel_Zero").Find("Slider").GetComponent<Slider>().value = (int)Random.Range(0, 5000);
    }
}
