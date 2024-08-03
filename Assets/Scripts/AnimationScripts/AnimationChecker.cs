using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChecker : MonoBehaviour
{
    public static AnimationChecker Instance;
    Animator animator;
    GameObject player;
    AnimatorClipInfo[] animatorinfo;
    public string current_animation;
    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = player.GetComponent<Animator>();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            animatorinfo = this.animator.GetCurrentAnimatorClipInfo(0);
            current_animation = animatorinfo[0].clip.name;  
        }
        
    }
}
