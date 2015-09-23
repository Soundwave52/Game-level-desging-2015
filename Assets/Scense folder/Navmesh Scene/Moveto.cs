using UnityEngine;
using System.Collections;

public class Moveto : MonoBehaviour {


	public Transform goal;
	NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	

	void Update () {
		agent.destination = goal.position;
	}
}
