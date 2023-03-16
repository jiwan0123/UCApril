using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float Sec;
    public int Min;
    

    [SerializeField] public TMP_Text TimerText;
    
    void Start()
    {
        TimerText.text = Sec.ToString();
    }

    
    public void Update()
    {
        TimerGo();
    }

    void TimerGo()
    {
        
        
            Sec -= Time.deltaTime;
            
            TimerText.text = string.Format("{0:D2}:{1:D2}", Min, (int)Sec);
            if((int)Sec <=0 && Min >= 0)
            {
                 Sec = 60;
                 Min --;
                if(Min <= -1 )
                {
                    Sec = 0;
                    Min = 0;
                    
                }
            }

        
        
    }

    
}
