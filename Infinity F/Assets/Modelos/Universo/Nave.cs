using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour {
    [SerializeField]
    Vector3 pos;
    Vector3 actual;
    // Use this for initialization
    void Start () {
        pos = new Vector3(0, 0, 0);
        actual = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {

        actual.x += (pos.x - actual.x) * Time.deltaTime * 0.0001f;
        actual.y += (pos.x - actual.x) * Time.deltaTime * 0.0001f;
        print(actual);
        transform.Translate(actual);
	}
    void OnMouseDown() {
        pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos.z += 10;
    }
}
