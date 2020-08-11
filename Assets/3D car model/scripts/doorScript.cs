using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    Animation anim;
     bool doorStat=false;

    // Start is called before the first frame update
    void Start()
    {
         anim= GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void doorControl(){
            if(doorStat==false){
                    anim["dooryAnim"].speed=1;
                    anim.Play();
                    doorStat=true;
            }
            else if(doorStat==true){
                    anim["dooryAnim"].speed=-1;
                    anim["dooryAnim"].time = anim["dooryAnim"].length;
                    anim.Play();
                    doorStat=false;
            }
    }

     
}
