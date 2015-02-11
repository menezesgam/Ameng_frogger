using UnityEngine;
using System.Collections;

public class FrogControl : MonoBehaviour
{

		private float speed = 2.5f;
		private Animator animator;

		// Use this for initialization
		void Start ()
		{
				animator = gameObject.GetComponent<Animator> ();

		}
	
		// Update is called once per frame
		void Update ()
		{
				int horizontal = (int)Input.GetAxisRaw ("Horizontal");
				int vertical = (int)Input.GetAxisRaw ("Vertical");

				if (horizontal != 0) {
						gameObject.transform.eulerAngles = new Vector3 (0, 0, horizontal * -90f);
				} else {
						if (vertical > 0) {
								gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
						} else if (vertical < 0) {
								gameObject.transform.eulerAngles = new Vector3 (0, 0, 180f);
						}
				}

				if (horizontal != 0 || vertical != 0) {
						animator.SetBool ("isMoving", true);
						gameObject.transform.Translate (0, speed * Time.deltaTime, 0);
				} else {
						animator.SetBool ("isMoving", false);
				}
		}
}
