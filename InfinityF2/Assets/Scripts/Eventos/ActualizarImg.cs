using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarImg : MonoBehaviour {
    [SerializeField]
    Sprite[] planetas = new Sprite[7];
    [SerializeField]
    Dropdown dropdown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Actualizar() {
        this.GetComponent<Image>().sprite = planetas[dropdown.value];
    }
}
