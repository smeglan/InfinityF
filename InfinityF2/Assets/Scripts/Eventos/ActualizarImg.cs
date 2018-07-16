using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarImg : MonoBehaviour {
    [SerializeField]
    Sprite[] planetas = new Sprite[8];
    [SerializeField]
    Dropdown dropdown;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void Actualizar() {
        if (dropdown.value == 7)
        {
            this.GetComponent<Image>().sprite = planetas[7];
            transform.parent.parent.Find("Panel_Recursos").gameObject.SetActive(false);
        }
        else { 
            this.GetComponent<Image>().sprite = planetas[dropdown.value];
            transform.parent.parent.Find("Panel_Recursos").gameObject.SetActive(true);
        }
    }
}
