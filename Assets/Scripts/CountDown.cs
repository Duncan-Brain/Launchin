using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class CountDown : MonoBehaviour {

  public int timeLeft = 10; //Seconds Overall
  public Text countdown; //UI Text Object

  void Start () {
    StartCoroutine("LoseTime");
    Time.timeScale = 1; //Just making sure that the timeScale is right
  }

  void Update () {
		if(countdown){
			countdown.text = ("" + timeLeft); //Showing the Score on the Canvas
		}
  }

  //Simple Coroutine
  IEnumerator LoseTime()
  {
    while (true) {
      yield return new WaitForSeconds (1);
      timeLeft--;

			if(timeLeft <= 0)
			{break;}
    }

  }}
