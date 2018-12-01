using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Behavior : MonoBehaviour {
    public int health;
    public Slider healthBar;
    public GameObject Meteor;
    public bool wall;
    public bool hit;
    public Transform player;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject[] Enemies;
    public AudioSource BossAttack;
    public AudioSource Deathscript;
    public AudioSource[] Hits;
    public AudioSource Ow;
    public int scene;
    public int index;
    
    private void Awake()
    {
        hit = false;
        wall = false;
    }
    private void Update()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        healthBar.value = health;
        index = Random.Range(0, Hits.Length);
        if (health <= 50&&wall==false)
        {
            health = health + Enemies.Length * 10;
            Debug.Log(health+Enemies.Length);
            BossAttack.Play();
            Ow.Stop();
            wall = true;
            Instantiate(wall1, new Vector2(transform.position.x -7, transform.position.y), Quaternion.identity);
            Instantiate(wall1, new Vector2(transform.position.x +7, transform.position.y), Quaternion.identity);
            Instantiate(wall2, new Vector2(transform.position.x, transform.position.y+5), Quaternion.identity);
            Instantiate(wall2, new Vector2(transform.position.x, transform.position.y-5), Quaternion.identity);
            player.transform.position = new Vector3(player.transform.position.x - 20, player.transform.position.y, player.transform.position.z);
            Instantiate(Meteor, new Vector2(-42.7f, player.transform.position.y+10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-36f, player.transform.position.y + 10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-25.2f, player.transform.position.y + 10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-14.7f, player.transform.position.y + 10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-5.9f, player.transform.position.y + 10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-20.3f, player.transform.position.y + 10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-12.9f, player.transform.position.y + 10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-1.8f, player.transform.position.y + 10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-7.6f, player.transform.position.y + 10), Quaternion.identity);
            Instantiate(Meteor, new Vector2(-8.2f, player.transform.position.y + 10), Quaternion.identity);

        }
        if (health <= 0)
        {
            Deathscript.Play();
            SceneManager.LoadScene(scene);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
    
            if (coll.tag == "Blade"&&hit==false)
            {
                health = health - 10;
                Ow = Hits[index];
                Ow.Play();
                Debug.Log(health);
                hit = true;

               
            }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hit = false;
        }
    }
    


}
