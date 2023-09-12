using UnityEngine;
using System.Collections;

public class Enviroment : MonoBehaviour
{
	//TODO:
	//Esta clase va a contener toda la información necesaria 
	//para que el aldeano pueda decidir que hacer (acceden a esta info haciendo algo como
	//EnviromentData.Instance.foodQty).
	//Por ejemplo acá pueden poner:
	//1. Cuanta madera tiene (la necesita para construir)
	public int wood=0;
	//2. Cuanta comida tiene (la necesita para vivir)
	public int food = 0;
	//3. Estado del clima (si llueve no debería salir de su casa porque se enferma)
	public bool rain=false;
	//4. Momento del día (de noche es peligroso salir)	
	public bool night=false;

    
    #region DONT TOUCH THIS
    public Citizen citizen;
	public static Enviroment Instance { get; private set; }
	void Awake()
	{
		Instance = this;
	}
#endregion
}
