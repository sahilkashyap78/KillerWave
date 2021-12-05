using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IActorTemplate {
	int sendDamage();
	void TakeDamage(int incomingDamage);
	void Die();
	void ActorStates();
}
