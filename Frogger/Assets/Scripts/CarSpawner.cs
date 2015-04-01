using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour
{

		public Transform startPoint; 
		public Transform endPoint;
		public GameObject carPrefab;
		public float timeToSpawn = 6f; //Intervalo entre os carros
		private float elapsedTime; //Contador do tempo

		void Update ()
		{
				elapsedTime += Time.deltaTime;
				if (elapsedTime >= timeToSpawn) {
						elapsedTime = 0;
						createCar ();
				}
		}

		private void createCar ()
		{
				Quaternion rotation = Quaternion.identity;
				if (endPoint.position.x < startPoint.position.x) {
						rotation = Quaternion.Euler (0f, 180f, 0f);
				}
				GameObject carroCriado = (GameObject)Instantiate (carPrefab, startPoint.position, rotation);
				carroCriado.SendMessage ("EndPoint", endPoint.position);
		}
}
