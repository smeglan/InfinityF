using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinity : MonoBehaviour {

    private int combustible;
    private int capacidadCombustible;
    private int sondasActuales;
    private int capacidadSondas;
    private int almacenamiento;
    private int iridio;
    private int platino;
    private int paladio;
    private float posicionX;
    private float posicionY;
    private int vida;
    private Mejoras mejora1;
    private Mejoras mejora2;
    private Mejoras mejora3;
    private Mejoras mejora4;
    private Mejoras mejora5;
    private Mejoras mejora6;
    private Mejoras mejora7;
    private Mejoras mejora8;

    // Use this for initialization
    void Start () {
        combustible = 100000;
        sondasActuales = 15;
        vida = 1200;
        mejora1 = new Mejoras(500, 120, 1600, 1800,"escudo multinucleo",false);
        mejora2 = new Mejoras(4000, 5500, 3500, 5100, "blindaje para naves pesadas", false);
        mejora3 = new Mejoras(4000, 6000, 6000, 16000, "cañon Thanix", false);
        mejora4 = new Mejoras(1000, 800, 1200, 1500, "propulsor onix", false);
        mejora5 = new Mejoras(2500, 3000, 2800, 3500, "cañon plasma", false);
        mejora6 = new Mejoras(4000, 4000, 4000, 4000, "capacidad de depositos", false);
        mejora7 = new Mejoras(500, 1000, 1000, 1000, "vida infiniy", false);
        mejora8 = new Mejoras(1500, 2000, 1500, 3000, "capacidad de combustible", false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Mejoras
{
    private int cantidadElementoZero;
    private int cantidadIridio;
    private int cantidadPaladio;
    private int cantidadPlatino;
    private string nombre;
    private bool activo;

    public Mejoras(int cantidadElementoZero, int cantidadIridio, int cantidadPaladio, int cantidadPlatino, string nombre, bool activo)
    {
        this.cantidadElementoZero = cantidadElementoZero;
        this.cantidadIridio = cantidadIridio;
        this.cantidadPaladio = cantidadPaladio;
        this.cantidadPlatino = cantidadPlatino;
        this.nombre = nombre;
        this.activo = false;
    }
}
