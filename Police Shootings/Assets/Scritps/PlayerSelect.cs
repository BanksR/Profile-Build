using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour
{
	public GameObject dialogCanvas;
	public GameObject cameraCanvas;
	public GameObject whitePersonCanvas;
	public GameObject playerCamera;
	public GameObject mainCamera;
	public GameObject blackPerson;
	public GameObject whitePerson;
	public GameObject policeSpeech;

	public void Start()
	{
		cameraCanvas.SetActive(true);
		dialogCanvas.SetActive(false);
		whitePersonCanvas.SetActive(false);

		playerCamera.SetActive(false);
		mainCamera.SetActive(true);

		blackPerson.SetActive(true);
		whitePerson.SetActive(true);
	}

	public void BlackPerson()
	{
		cameraCanvas.SetActive(false);
		dialogCanvas.SetActive(true);
		whitePersonCanvas.SetActive(false);

		mainCamera.SetActive(false);
		playerCamera.SetActive(true);

		blackPerson.SetActive(false);
		whitePerson.SetActive(false);

		policeSpeech.SetActive(true);
	}

	public void WhitePerson()
	{
		cameraCanvas.SetActive(false);
		dialogCanvas.SetActive(false);
		whitePersonCanvas.SetActive(true);


		mainCamera.SetActive(false);
		playerCamera.SetActive(true);

		blackPerson.SetActive(false);
		whitePerson.SetActive(false);

		policeSpeech.SetActive(false);
	}
}
