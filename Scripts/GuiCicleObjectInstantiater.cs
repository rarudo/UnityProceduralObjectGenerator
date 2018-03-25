using UnityEngine;

namespace ProcedualObjectGenerator.Scripts
{
	[RequireComponent(typeof(CircleObjectInstantiater))]
	public class GuiCicleObjectInstantiater: MonoBehaviour
	{
		[SerializeField]
		private GameObject _createObj;
		[SerializeField] protected int Quantity = 30;
		[SerializeField] protected float Radius = 10;

		// Use this for initialization
		void Awake()
		{
			CircleObjectInstantiater co = GetComponent<CircleObjectInstantiater>();
			co.InstantiateObject(_createObj,Radius,Quantity);
		}
	
		// Update is called once per frame
		void Update () {
		
		}
	}
}
