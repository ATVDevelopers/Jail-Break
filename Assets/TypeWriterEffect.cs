﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TypeWriterEffect : MonoBehaviour {

    public AudioSource key;

    public float delay = 0.2f;
    public string fullText;
    private string currentText = "";

	// Use this for initialization
	void Start () {
        StartCoroutine(ShowText());

	}
	
    IEnumerator ShowText(){
        for (int i = 0; i <= fullText.Length; i++){
            currentText = fullText.Substring(0, i);
            key.Play();
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
        SceneManager.LoadScene(1);
    }
}
