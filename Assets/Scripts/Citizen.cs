﻿using UnityEngine;
using System.Collections;

public class Citizen : MonoBehaviour
{
	//TODO: 
	//1. Colocar el nodo raíz.
	public Node node;
    //2. Hacer lo que sea necesario para updatear las desiciones
    //del aldeano.
    private void Start()
	{
		node.Execute(this);
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
			node.Execute(this);
		}
		
	}



    #region DONT TOUCH THIS
    public ParticleSystem sleepPos;
	public ParticleSystem getWoodPos;
	public ParticleSystem farmingPos;
	public ParticleSystem buildPos;

	public void GetFood()
	{
		Debug.Log("Decision: Get Food!");
		DeactivateAllParticles();		
		SetPosAndPlayParticle(farmingPos);
	}

	public void GetWood()
	{
		Debug.Log("Decision: Get Wood!");
		DeactivateAllParticles();		
		SetPosAndPlayParticle(getWoodPos);
	}

	public void BuildHouses()
	{
		Debug.Log("Decision: Build!");
		DeactivateAllParticles();		
		SetPosAndPlayParticle(buildPos);
	}

	public void GoToSleep()
	{
		Debug.Log("Decision: Go to Sleep!");
		DeactivateAllParticles();		
		SetPosAndPlayParticle(sleepPos);
	}

	private void DeactivateAllParticles()
	{
		sleepPos.Stop();
		getWoodPos.Stop();
		farmingPos.Stop();
		buildPos.Stop();
	}

	private void SetPosAndPlayParticle(ParticleSystem target)
	{
		transform.position = target.transform.position;
		target.Play();
	}
#endregion
}
