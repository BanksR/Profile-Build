using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathPanel : MonoBehaviour
{
	public AnimationClip death;
	Animation animator;

	public GameObject policeman;
	public GameObject policeCar;

	public GameObject blackNewspaper;

	public GameObject panel;

	private void Start()
	{
		blackNewspaper.SetActive(false);
		panel.SetActive(false);
		policeman.SetActive(false);
		policeCar.SetActive(false);
		animator = GetComponent<Animation>();
	}

	public void OnTriggerEnter(Collider other)
	{
		print("Hit Police Speech");
		panel.SetActive(true);
		policeman.SetActive(true);
		policeCar.SetActive(true);
		blackNewspaper.SetActive(true);
		GetComponent<Animator>().SetBool("FadePanel", true);
	}
}