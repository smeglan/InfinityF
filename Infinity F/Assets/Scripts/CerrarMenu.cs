using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarMenu : MonoBehaviour {
    [SerializeField]
    private GameObject padre;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cerrarMenu() {
        padre.SetActive(false);
    }
}
