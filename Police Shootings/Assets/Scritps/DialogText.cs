using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogText : MonoBehaviour
{
	public AnimationClip death;
	Animation animator;

	public GameObject policeman;
	public GameObject policeCar;

	public GameObject blackNewspaper;

	public GameObject panel;
	public GameObject deathCanvas;

	[TextArea(10, 10)]
	public string DialogToGive;

	private string[] dialogArray;
	public Queue<string> DialogQ;

	public string DialogGiversName = "";

	public bool hasTextToDisplay = true;

	void Awake()
	{
		ReQueue();
	}

	public string DQ()
	{

		if (DialogQ.Count != 0 && hasTextToDisplay)
		{
			string t = DialogQ.Dequeue();
			return t;
		}

		hasTextToDisplay = false;

		if(hasTextToDisplay == false)
		{
			print("Hit Police Speech");
			panel.SetActive(true);
			policeman.SetActive(true);
			policeCar.SetActive(true);
			blackNewspaper.SetActive(true);
			deathCanvas.SetActive(true);
			GetComponent<Animator>().SetBool("FadePanel", true);
		}

		return "";
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player") && hasTextToDisplay)
		{
			DialogManager.Instance.dialogText = this;
			DialogManager.Instance.TriggerAnim();
			ReQueue();
		}
	}

	private void ReQueue()
	{
		hasTextToDisplay = true;
		DialogQ = new Queue<string>();
		dialogArray = (DialogToGive.Split('\n'));
		foreach (var line in dialogArray)
		{
			DialogQ.Enqueue(line);
		}
	}
}