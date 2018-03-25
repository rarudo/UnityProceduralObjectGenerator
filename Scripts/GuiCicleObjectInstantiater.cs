using UnityEngine;

namespace ProcedualObjectGenerator.Scripts
{
	[RequireComponent(typeof(CircleObjectInstantiater))]
	public class GuiCicleObjectInstantiater: MonoBehaviour
	{
		[SerializeField]
		private GameObject _createObj;
		[SerializeField]
		private int _quantity;
		[SerializeField]
		private float _radius;

		// Use this for initialization
		void Awake()
		{
			CircleObjectInstantiater co = GetComponent<CircleObjectInstantiater>();
			co.InstantiateObject(_createObj,_radius,_quantity);
		}
	
		// Update is called once per frame
		void Update () {
		
		}
	}
}
