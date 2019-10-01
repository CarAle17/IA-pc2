using UnityEngine;

public class Agent : SBAgent
{
	public Transform target;
	public Transform center;

	void Start()
	{
		maxSpeed = 10f;
		maxSteer = 0.5f;


	}

	void Update()
	{
		velocity += SteeringBehaviours.Seek(this, target, 2);

		//Quede dentro de un circulo
		//velocity += SteeringBehaviours.Circle(this, target, center, 2);

		//quede dentro de un cuadrado
		velocity += SteeringBehaviours.Rectangle(this, target, center, 2 , 2);
		transform.position += velocity * Time.deltaTime;
	}


}
