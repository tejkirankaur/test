using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableTyrantPlayer : Selectable
{
    [SerializeField]
    private Material def, hover, selected;
    private bool isSelected = false;
    public Animator anim;
    public int poseNum;
    public AudioSource sound;

    public override GameObject OnSelect()
    {
        isSelected = true;
        anim.SetInteger("IdleVariant", poseNum);
        gameObject.GetComponent<MeshRenderer>().material = selected;
        sound.Play();
        return this.gameObject;
    }

    public override GameObject OnHover()
    {
        if (gameObject.GetComponent<MeshRenderer>().material != hover && !isSelected)
        {
            gameObject.GetComponent<MeshRenderer>().material = hover;
        }
        return this.gameObject;
    }

    public override void OnDeselect()
    {
        isSelected = false;
        anim.SetInteger("IdleVariant", 0);
        gameObject.GetComponent<MeshRenderer>().material = def; 
    }
}
