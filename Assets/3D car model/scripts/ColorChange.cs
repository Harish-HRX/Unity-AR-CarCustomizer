using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ColorChange : MonoBehaviour
{
     public Material carMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void ChangeColor(){
            string Buttonname= EventSystem.current.currentSelectedGameObject.name;
            if(Buttonname=="Black"){
                carMaterial.color=new Color(0/255f,0/255f,0/255f);
            }
            else if(Buttonname=="Orange"){
                carMaterial.color=new Color(250/255f,81/255f,6/255f);
            }
            else if(Buttonname=="Purple"){
                carMaterial.color=new Color(144/255f,8/255f,248/255f);
            }
            else if(Buttonname=="White"){
                carMaterial.color=new Color(242/255f,248/255f,242/255f);
            }
    }
}
