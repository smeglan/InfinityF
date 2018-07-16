using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistema : MonoBehaviour {

    [SerializeField]
    public string nombre { get; set; }
    [SerializeField]
    public int riqueza { get; set; }

    void Start () {
        nombre = "System";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
