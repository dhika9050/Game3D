using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HealthPoint : MonoBehaviour
{
	private EnemyAnimator enemny_anim;
	private NavMeshAgent navAgent;
	private EnemyController enemy_Controller;

	public float health = 100f;

	public bool isPlayer, isFox;

	private bool isDead;

	void Awake(){
		if(isFox){
			enemy_anim = GetComponent<EnemyAnimator>();
			enemy_Controller = GetComponent<enemy_Controller>();
			navAgent = GetComponent<NavMeshAgent>();
		}
	}

	public void ApplyDamage(float Damage){

	}

	void PlayerDead(){

	}

	void RestartGame(){

	}

	void TurnOffGameObject(){

	}

	
}
