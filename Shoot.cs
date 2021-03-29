using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject Bullet1;
    public GameObject Bullet2;
    public GameObject Bullet3;
    public GameObject Bullet4;
    public GameObject Bullet5;
    public GameObject Bullet6;
    public GameObject Bullet7;
    public GameObject Bullet8;
    public static float reloadTime = 0.5f;
    public static float baseReload = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        reloadTime = baseReload;
        StartCoroutine("ShootEm");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            if (Input.GetKey("right"))
            {
                GetComponent<Animator>().SetInteger("Direction", 2);
            }
            else if (Input.GetKey("left"))
            {
                GetComponent<Animator>().SetInteger("Direction", 8);
            }
            else
            {
                GetComponent<Animator>().SetInteger("Direction", 1);
            }
        }
        else if (Input.GetKey("down"))
        {
            if (Input.GetKey("right"))
            {
                GetComponent<Animator>().SetInteger("Direction", 4);
            }
            else if (Input.GetKey("left"))
            {
                GetComponent<Animator>().SetInteger("Direction", 6);
            }
            else
            {
                GetComponent<Animator>().SetInteger("Direction", 5);
            }
        }
        else if (Input.GetKey("left"))
        {
            GetComponent<Animator>().SetInteger("Direction", 7);
        }
        else if (Input.GetKey("right"))
        {
            GetComponent<Animator>().SetInteger("Direction", 3);
        }
    }

    IEnumerator ShootEm()
    {
        if (Input.GetKey("up"))
        {
            if (Global.multi == true)
            {
                Instantiate(Bullet1, transform.position, transform.rotation);
                Instantiate(Bullet2, transform.position, transform.rotation);
                Instantiate(Bullet3, transform.position, transform.rotation);
                Instantiate(Bullet4, transform.position, transform.rotation);
                Instantiate(Bullet5, transform.position, transform.rotation);
                Instantiate(Bullet6, transform.position, transform.rotation);
                Instantiate(Bullet7, transform.position, transform.rotation);
                Instantiate(Bullet8, transform.position, transform.rotation);
                yield return new WaitForSeconds(reloadTime);
                StartCoroutine("ShootEm");
            }
            else
            {
                if (Input.GetKey("right"))
                {
                    if (Global.burst == true)
                    {
                        Instantiate(Bullet1, transform.position, transform.rotation);
                        Instantiate(Bullet2, transform.position, transform.rotation);
                        Instantiate(Bullet3, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                    else
                    {
                        Instantiate(Bullet2, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                }
                else if (Input.GetKey("left"))
                {
                    if (Global.burst == true)
                    {
                        Instantiate(Bullet7, transform.position, transform.rotation);
                        Instantiate(Bullet8, transform.position, transform.rotation);
                        Instantiate(Bullet1, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                    else
                    {
                        Instantiate(Bullet8, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                }
                else
                {
                    if (Global.burst == true)
                    {
                        Instantiate(Bullet8, transform.position, transform.rotation);
                        Instantiate(Bullet1, transform.position, transform.rotation);
                        Instantiate(Bullet2, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                    else
                    {
                        Instantiate(Bullet1, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                }
            }
        }
        else if (Input.GetKey("down"))
        {
            if (Global.multi == true)
            {
                Instantiate(Bullet1, transform.position, transform.rotation);
                Instantiate(Bullet2, transform.position, transform.rotation);
                Instantiate(Bullet3, transform.position, transform.rotation);
                Instantiate(Bullet4, transform.position, transform.rotation);
                Instantiate(Bullet5, transform.position, transform.rotation);
                Instantiate(Bullet6, transform.position, transform.rotation);
                Instantiate(Bullet7, transform.position, transform.rotation);
                Instantiate(Bullet8, transform.position, transform.rotation);
                yield return new WaitForSeconds(reloadTime);
                StartCoroutine("ShootEm");
            }
            else
            {
                if (Input.GetKey("right"))
                {
                    if (Global.burst == true)
                    {
                        Instantiate(Bullet3, transform.position, transform.rotation);
                        Instantiate(Bullet4, transform.position, transform.rotation);
                        Instantiate(Bullet5, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                    else
                    {
                        Instantiate(Bullet4, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                }
                else if (Input.GetKey("left"))
                {
                    if (Global.burst == true)
                    {
                        Instantiate(Bullet5, transform.position, transform.rotation);
                        Instantiate(Bullet6, transform.position, transform.rotation);
                        Instantiate(Bullet7, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                    else
                    {
                        Instantiate(Bullet6, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                }
                else
                {
                    if (Global.burst == true)
                    {
                        Instantiate(Bullet4, transform.position, transform.rotation);
                        Instantiate(Bullet5, transform.position, transform.rotation);
                        Instantiate(Bullet6, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                    else
                    {
                        Instantiate(Bullet5, transform.position, transform.rotation);
                        yield return new WaitForSeconds(reloadTime);
                        StartCoroutine("ShootEm");
                    }
                }
            }
        }
        else if (Input.GetKey("left"))
        {
            if (Global.multi == true)
            {
                Instantiate(Bullet1, transform.position, transform.rotation);
                Instantiate(Bullet2, transform.position, transform.rotation);
                Instantiate(Bullet3, transform.position, transform.rotation);
                Instantiate(Bullet4, transform.position, transform.rotation);
                Instantiate(Bullet5, transform.position, transform.rotation);
                Instantiate(Bullet6, transform.position, transform.rotation);
                Instantiate(Bullet7, transform.position, transform.rotation);
                Instantiate(Bullet8, transform.position, transform.rotation);
                yield return new WaitForSeconds(reloadTime);
                StartCoroutine("ShootEm");
            }
            else if (Global.burst == true)
            {
                Instantiate(Bullet6, transform.position, transform.rotation);
                Instantiate(Bullet7, transform.position, transform.rotation);
                Instantiate(Bullet8, transform.position, transform.rotation);
                yield return new WaitForSeconds(reloadTime);
                StartCoroutine("ShootEm");
            }
            else
            {
                Instantiate(Bullet7, transform.position, transform.rotation);
                yield return new WaitForSeconds(reloadTime);
                StartCoroutine("ShootEm");
            }
        }
        else if (Input.GetKey("right"))
        {
            if (Global.multi == true)
            {
                Instantiate(Bullet1, transform.position, transform.rotation);
                Instantiate(Bullet2, transform.position, transform.rotation);
                Instantiate(Bullet3, transform.position, transform.rotation);
                Instantiate(Bullet4, transform.position, transform.rotation);
                Instantiate(Bullet5, transform.position, transform.rotation);
                Instantiate(Bullet6, transform.position, transform.rotation);
                Instantiate(Bullet7, transform.position, transform.rotation);
                Instantiate(Bullet8, transform.position, transform.rotation);
                yield return new WaitForSeconds(reloadTime);
                StartCoroutine("ShootEm");
            }
            else if (Global.burst == true)
            {
                Instantiate(Bullet2, transform.position, transform.rotation);
                Instantiate(Bullet3, transform.position, transform.rotation);
                Instantiate(Bullet4, transform.position, transform.rotation);
                yield return new WaitForSeconds(reloadTime);
                StartCoroutine("ShootEm");
            }
            else
            {
                Instantiate(Bullet3, transform.position, transform.rotation);
                yield return new WaitForSeconds(reloadTime);
                StartCoroutine("ShootEm");
            }
        }
        else
        {
            yield return new WaitForSeconds(0.1f);
            StartCoroutine("ShootEm");
        }
    }
}
