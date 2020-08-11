using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ligthScript : MonoBehaviour
{
    public Material frontLight;
    bool lightStatus =false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void lightOnOff(){
            if(lightStatus==false){
                    frontLight.SetColor("_TintColor",Color.white);
                    lightStatus =true;
            }
            else{
                 frontLight.SetColor("_TintColor",Color.black);
                lightStatus =false;;
            }
    }

}
