﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClickSound : MonoBehaviour {

	public AudioClip sound;
	string music;
	private Button button { get { return GetComponent<Button>();}}
	private AudioSource source { get { return GetComponent<AudioSource>();}}

	// Use this for initialization
	void Start () {

		gameObject.AddComponent<AudioSource>();
		source.clip = sound;
		source.playOnAwake = false;

		button.onClick.AddListener(() => PlaySound());

	}
	
	// Update is called once per frame
	void PlaySound () {
		music = PlayerPrefs.GetString("music");
		if (music != "off") source.PlayOneShot(sound);
	}
}
