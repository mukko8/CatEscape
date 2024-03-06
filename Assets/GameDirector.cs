using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIを使うので忘れずに追加

public class GameDirector : MonoBehaviour
{
    public GameObject gameOver;
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge=GameObject.Find("hpGauge");  
    }
    public void DecreaseHp(){
        Image hp=this.hpGauge.GetComponent<Image>();
        hp.fillAmount-=0.1f;
        if(hp.fillAmount<=0f){
            gameOver.SetActive(true);
            Time.timeScale=0f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
