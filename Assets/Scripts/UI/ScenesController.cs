using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour {

	public string SceneToLoad;

	public float time = 0.5F;


	public void ChangeScene(){

		Time.timeScale = 1;

		StartCoroutine ("DisplayScene");		
	}



	IEnumerator DisplayScene(){
		yield return new WaitForSeconds(time);
		SceneManager.LoadScene(SceneToLoad);
	}
}