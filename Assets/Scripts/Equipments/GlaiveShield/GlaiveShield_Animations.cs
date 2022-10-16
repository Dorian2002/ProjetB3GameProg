using System;
using System.Collections;
using System.Collections.Generic;
using PlayerScripts;
using UnityEngine;

public class GlaiveShield_Animations : MonoBehaviour
{
    [SerializeField] private Rigidbody playerBody;
    [SerializeField] private Movements playerMovements;
    [SerializeField] private Transform playerTransform;
    private Animator anim;

    private void Start()
    {
        playerBody = GetComponentInParent<Rigidbody>();
        playerMovements = GetComponentInParent<Movements>();
        anim = GetComponentInParent<Animator>();
    }

    public void Drill()
    {
        playerBody.AddForce(playerBody.transform.forward * 600);
    }
    
    public void Undefeated()
    {
        StartCoroutine(UseUndefeated());
    }
    
    public void Stampede()
    {
        float time = 0;
        playerMovements.SetSpeed(10);
        while (anim.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Glaive&Shield_Stampede")
        { 
           Debug.Log(anim.GetCurrentAnimatorClipInfo(0)[0].clip.name);
           time += Time.deltaTime;
           if (time >= 10)
           {
               playerMovements.SetSpeed(5);
           }
        }
        playerMovements.SetSpeed(5);
    }

    private IEnumerator UseUndefeated()
    {
        transform.localScale.Scale(new Vector3(3f, 3f, 3f));
        yield return new WaitForSeconds(5);
        playerBody.transform.localScale.Scale(new Vector3(1f, 1f, 1f));
    }
}


