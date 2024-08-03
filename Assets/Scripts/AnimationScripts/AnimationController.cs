using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Button macarenaButton, hiphopButton, houseButton;

    [SerializeField]
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        macarenaButton.onClick.AddListener(macarenaAnimation);
        hiphopButton.onClick.AddListener(hiphopAnimation);
        houseButton.onClick.AddListener(houseAnimation);
    }

    // Cambiar la animacion del objeto segun el onClick
    public void macarenaAnimation()
    {
        anim.SetTrigger("MacarenaTrig");
    }
    public void hiphopAnimation()
    {
        anim.SetTrigger("HipHopTrig");

    }
    public void houseAnimation()
    {
        anim.SetTrigger("HouseTrig");
    }
}
