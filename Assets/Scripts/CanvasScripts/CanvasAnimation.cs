using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    GameObject obj;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        obj = GameObject.FindGameObjectWithTag("AnimChecker");
        if (obj != null)
        {
            //Se llama a la variable current_animation del gameobject para obtener el nombre de la animacion
            setAnimation(obj.GetComponent<AnimationChecker>().current_animation);
        }
        
    }

    //Se activa un trigger segun la animacion
    void setAnimation(string animName)
    {
        if (animName == "Wave Hip Hop Dance")
        {
            anim.SetTrigger("HipHopTrig");
        }
        if (animName == "House Dancing")
        {
            anim.SetTrigger("HouseTrig");
        }
        if (animName == "Macarena Dance")
        {
            anim.SetTrigger("MacarenaTrig");
        }
    }
}
