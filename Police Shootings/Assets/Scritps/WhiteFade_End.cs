using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiteFade_End : MonoBehaviour
{
	public AnimationClip Fade;
    public GameObject Text;
    Animation animator;

	public GameObject panel;

    private void Start()
    {
		panel.SetActive(false);
        animator = GetComponent<Animation>();
    }
    public void OnTriggerEnter(Collider other)
    {
		panel.SetActive(true);
        Text.SetActive(true);
        print("Hit House");
        GetComponent<Animator>().SetBool("FadePanel", true);
	}

}