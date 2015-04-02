using UnityEngine;
using System.Collections;

public class FrogCollision : MonoBehaviour
{

		private Vector3 startPosition;
		// Use this for initialization
		void Start ()
		{
				startPosition = transform.position;
		}

		public void OnTriggerEnter2D (Collider2D col)
		{
				transform.position = startPosition;
		}
}
