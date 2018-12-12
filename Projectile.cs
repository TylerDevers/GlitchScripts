﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	[SerializeField] float speed = 10f;
	[SerializeField] int healthPoints = 2;
	[SerializeField] float damage = 50f;

	void Update () {
		transform.Translate(Vector2.right * Time.deltaTime * speed);
	}

	private void OnTriggerEnter2D (Collider2D otherCollider)
	{
		var health = otherCollider.GetComponent<Health>();
		var attacker = otherCollider.GetComponent<Attacker>();

		if (attacker && health)
		{
			health.DealDamage(damage);
			Destroy(gameObject);
		}
		
	}
}
