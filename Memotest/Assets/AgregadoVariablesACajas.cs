using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregadoVariablesACajas : MonoBehaviour {

	public int variableDeCaja;
	public ControladorDeCajas controlador;

	void Start () {
		
	}
		
	void OnMouseDown(){
		controlador.comparador (gameObject.GetComponent<AgregadoVariablesACajas>());
	}
}
