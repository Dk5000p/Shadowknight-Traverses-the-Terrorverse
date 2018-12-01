using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VHSMember : MonoBehaviour {
    public AudioSource card;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        card.Play();
        Inventory.VHSCard = true;
        Destroy(gameObject);
    }
}
