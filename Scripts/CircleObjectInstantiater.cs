using UnityEngine;

namespace ProcedualObjectGenerator.Scripts
{
	public class CircleObjectInstantiater : MonoBehaviour
	{
		[SerializeField]
		private GameObject _object; 
		[SerializeField]
		private float _radius;
		[SerializeField]
		private int _quantity;
		//回転する量
		private float _rotateDiff;

		// Use this for initialization
		void Start ()
		{
			_rotateDiff = 360 / _quantity;
			InstantiateObject();
		}

		void InstantiateObject()
		{
			GameObject[] objects = new GameObject[_quantity];
			for (int i = 0; i < _quantity; i++)
			{
				var obj = Instantiate(_object);
				obj.transform.position = transform.position;
				obj.transform.rotation = transform.rotation;
				obj.transform.position += obj.transform.right * _radius;
				transform.Rotate(0,_rotateDiff,0);
				obj.transform.Rotate(-90,0,0);
				objects[i] = obj;
			}

			foreach (var obj in objects)
			{
				obj.transform.parent = transform;
			}
		}
	
		// Update is called once per frame
		void Update () {
		}
	}
}
