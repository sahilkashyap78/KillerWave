﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

	GameObject actor;
	int hitPower;
	int health;
	int travelSpeed;
	[SerializeField]
	SOActorModel bulletModel;

	void Awake()
	{
		ActorStats(bulletModel);
	}

	void Update()
	{
		transform.position += new
		Vector3(travelSpeed, 0, 0) * Time.deltaTime;
	}


	public int SendDamage()
	{
		return hitPower;
	}
	public void TakeDamage(int incomingDamage)
	{
		health -= incomingDamage;
	}

	public void Die()
	{
		Destroy(this.gameObject);
	}

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

	public void ActorStats(SOActorModel actorModel)
	{
		hitPower = actorModel.hitPower;
		health = actorModel.health;
		travelSpeed = actorModel.speed;
		actor = actorModel.actor;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
		{
			if (other.GetComponent<IActorTemplate>() != null)
			{
				if (health >= 1)
				{
					health -= other.GetComponent<IActorTemplate>
					().SendDamage();
				}
				if (health <= 0)
				{
					Die();
				}
			}
		}
	}


	// Update is called once per frame
	
}
