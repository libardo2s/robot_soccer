using UnityEngine;
using System.Collections;

public class MasCercano : MonoBehaviour {

	// Use this for initialization
	public NavMeshAgent[] playerList;
	private Transform ballPosition;
	private float[] distancias;
	void Start () {
		GameObject ball = GameObject.FindWithTag("Ball");
		ballPosition = ball.transform;
		distancias = new float[playerList.Length];
	}
	void Update () {
		CalculateDistance();		
	}
	
	void CalculateDistance(){
		for(int i=0;i<playerList.Length;i++){
			distancias[i] = Vector3.Distance(playerList[i].gameObject.transform.position,ballPosition.position);
		}
		
		float minValue = distancias[0];
		int indice = 0;
		
		for (int i = 0; i < distancias.Length; i++)
		{
			if (distancias[i] < minValue){
				minValue = distancias[i];
				indice = i;				
			}
		}
		
		playerList[indice].SetDestination(ballPosition.position);
	}
}