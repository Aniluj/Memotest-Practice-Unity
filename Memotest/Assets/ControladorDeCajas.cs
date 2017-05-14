using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeCajas : MonoBehaviour {

	private AgregadoVariablesACajas caja1;
	private AgregadoVariablesACajas caja2;
	public int cont = 0;

	public void comparador(AgregadoVariablesACajas caja)
	{
		cont++;

		if (cont == 1) {
			caja1 = caja;
			} else {
			caja2 = caja;
			if (caja1.variableDeCaja == caja2.variableDeCaja) {
				Destroy (caja1.gameObject);
				Destroy (caja2.gameObject);
			}
			cont = 0;
		}
	}
}
