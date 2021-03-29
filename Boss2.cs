using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss2 : MonoBehaviour
{

    int maxHealth = 100;
    public static int health;
    int launchTime;
    public static int direction = 1;
    public GameObject laser1;
    public GameObject laser2;
    public GameObject laser3;
    public GameObject laser4;
    public GameObject crack1;
    public GameObject crack2;
    public GameObject life;
    public GameObject Megabooma;
    public GameObject trophy;
    public Transform trophySet;
    Text scoreboard;
    public Text lifeboard;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        lifeboard.text = "Health: " + health + "/" + maxHealth;
        StartCoroutine("ShootyThing");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ShootyThing()
    {
        if (health >= 90)
        {
            yield return new WaitForSeconds(1);
        }else if (health >= 70)
        {
            yield return new WaitForSeconds(0.75f);
        }else if (health >= 40)
        {
            yield return new WaitForSeconds(0.5f);
        }
        else
        {
            yield return new WaitForSeconds(0.25f);
        }
        if (direction == 1)
        {
            Instantiate(laser1, transform.position, transform.rotation);
        }else if (direction == 2)
        {
            Instantiate(laser2, transform.position, transform.rotation);
        }else if (direction == 3)
        {
            Instantiate(laser3, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(laser4, transform.position, transform.rotation);
        }
        StartCoroutine("ShootyThing");
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            Destroy(col.gameObject);
            health -= 1;
            if (health == 0)
            {
                lifeboard.text = "";
                scorekeeper.score += 1000000;
                scoreboard = (GameObject.FindWithTag("Score")).GetComponent<Text>();
                scoreboard.text = "Score: " + scorekeeper.score;
                Instantiate(life, transform.position, transform.rotation);
                Instantiate(Megabooma, new Vector3(0, 0, 0), transform.rotation);
                Instantiate(trophy, trophySet.transform.position, transform.rotation);
                Destroy(crack1.gameObject);
                Destroy(crack2.gameObject);
                GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject enemy in enemies)
                    GameObject.Destroy(enemy);
                Destroy(gameObject);
            }
            else
            {
                StartCoroutine("damage");
            }
        }
    }

    IEnumerator damage()
    {
        source.Play();
        lifeboard.text = "Health: " + health + "/" + maxHealth;
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
