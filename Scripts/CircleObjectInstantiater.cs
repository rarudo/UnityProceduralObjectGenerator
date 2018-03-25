using System;
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
		private GameObject[] _createdObjects;

		// Use this for initialization
		void Awake()
		{
			_rotateDiff = 360 / _quantity;
			InstantiateObject();
		}

		void InstantiateObject()
		{
			_createdObjects = new GameObject[_quantity];
			for (int i = 0; i < _quantity; i++)
			{
				var obj = Instantiate(_object);
				obj.transform.position = transform.position;
				obj.transform.rotation = transform.rotation;
				obj.transform.position += obj.transform.right * _radius;
				transform.Rotate(0,_rotateDiff,0);
				obj.transform.Rotate(-90,0,0);
				_createdObjects[i] = obj;
			}

			foreach (var obj in _createdObjects)
			{
				obj.transform.parent = transform;
			}
		}

		private GameObject[] GetCreateObjects()
		{
			return _createdObjects;
		}
	
		// Update is called once per frame
		void Update () {
		}
	}
}
