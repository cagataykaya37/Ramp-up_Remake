using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    GameObject player;
    Vector3 characterSpawnLoc;

    Rigidbody playerRB;
    DynamicJoystick joystick;
    TMP_Text lifeText, starText;

    int star = 0, life = 10;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = Resources.Load<GameObject>("Player");
        playerRB = this.gameObject.GetComponent<Rigidbody>();
        characterSpawnLoc = new Vector3(0, -2.75f, -4.8f);
        joystick = GameObject.Find("Dynamic Joystick").GetComponent<DynamicJoystick>();
        lifeText = GameObject.Find("LifeText").GetComponent<TMP_Text>();
        starText = GameObject.Find("StarText").GetComponent<TMP_Text>();
        PlayerPrefs.SetInt("Life", life);
        PlayerPrefs.SetInt("Star", star);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         playerRB.velocity = new Vector3(joystick.Horizontal * moveSpeed, playerRB.velocity.y, joystick.Vertical * moveSpeed);

    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            //Destroy(this.gameObject);
            Destroy(collision.gameObject);
            life--;
            lifeText.text = life + "";
            PlayerPrefs.SetInt("Life", life);
            PlayerPrefs.Save();
            playerRB.position = characterSpawnLoc;
            //Instantiate(player, characterSpawnLoc, new Quaternion(0,0,0,0));
        }
        else if (collision.gameObject.tag == "End")
        {
            playerRB.position = characterSpawnLoc;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Star", star++);
            PlayerPrefs.Save();
            starText.text = PlayerPrefs.GetInt("Star") + "";
        }
        else if (other.gameObject.tag == "Life")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Life", life++);
            PlayerPrefs.Save();
            lifeText.text = PlayerPrefs.GetInt("Star") + "";
        }
    }

}
