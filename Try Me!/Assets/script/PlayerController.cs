
using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public Camera cam;
	public NavMeshAgent agent;
	public static int Keys ;

	void Update () {
		



		Debug.Log (Keys);
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay (Input.mousePosition); 
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) 
			{
				agent.SetDestination(hit.point);
			}
		}

	}
}
