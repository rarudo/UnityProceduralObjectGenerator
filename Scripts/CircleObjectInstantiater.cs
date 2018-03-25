using System;
using UnityEngine;

namespace ProcedualObjectGenerator.Scripts
{
	public class CircleObjectInstantiater : MonoBehaviour
	{
		private GameObject[] _createdObjects;

		public void InstantiateObject(GameObject createObj,float radius, int quantity)
		{
			float rotateDiff = 360 / quantity;
			_createdObjects = new GameObject[quantity];
			for (int i = 0; i < quantity; i++)
			{
				var obj = Instantiate(createObj);
				obj.transform.position = transform.position;
				obj.transform.rotation = transform.rotation;
				obj.transform.position += obj.transform.right * radius;
				transform.Rotate(0,rotateDiff,0);
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
