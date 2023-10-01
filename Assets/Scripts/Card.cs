using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{ 
    private GameManager gm;

   

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        Discard();
    }

    public void Discard()
    {
        gm.discardPile.Add(this);
        gameObject.SetActive(false);
        gm.availableCardSlots[0] = true;

    }
}
