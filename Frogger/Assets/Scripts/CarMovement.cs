using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour
{

		private Vector3 endPoint;
		public float speed = 3f;

		// Update is called once per frame
		void Update ()
		{
				if (endPoint != null) {
						transform.position = Vector3.MoveTowards (transform.position, endPoint, speed * Time.deltaTime);
						if (transform.position == endPoint) {
								Destroy (gameObject);
						}
				}
		}

		public void EndPoint (Vector3 position)
		{
				endPoint = position;
		}
}
