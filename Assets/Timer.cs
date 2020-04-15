using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public int counter = 30;
	public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = counter.ToString();
        StartCoroutine(hitungmundur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator hitungmundur(){
    	while(counter > 0){
    	yield return new WaitForSeconds(1);
    	counter -= 1;
    	TimerText.text = counter.ToString();
    	}

    	SceneManager.LoadScene("HalamanBelakang");
    }
}
