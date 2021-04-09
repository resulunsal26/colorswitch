using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ballmanager : MonoBehaviour
{
    public Rigidbody2D ball;
    public float ziplamagucu;

    public Color turkuazrenk, morrenk, sarirenk, pemberenk;
    public string mevcutrenk;
    public SpriteRenderer ressam;
   
    [SerializeField]
    private Transform degistirici, kontrolbir, kontroliki, cemberbir, cemberiki;
    [SerializeField]
    private TextMeshProUGUI skortext;
    private int skor;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip ziplama;
    private void Start()
    {
        rastrenk();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ball.velocity = Vector2.up * ziplamagucu;
            audioSource.PlayOneShot(ziplama);
        }
       
        
    }
    private void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag!=mevcutrenk)
        {
            if (temas.gameObject.tag == "renkdegistir")
            {
                rastrenk();
                degistirici.position = new Vector3(degistirici.position.x, degistirici.position.y + 6, degistirici.position.z);
                skor += 20;
                skortext.text = "Skor : " + skor;
            }
          
            else  if(temas.gameObject.tag=="kontrolbir")
            {
                cemberbir.position = new Vector3(cemberbir.position.x, cemberbir.position.y + 12, cemberbir.position.z);
                kontrolbir.position = new Vector3(kontrolbir.position.x, kontrolbir.position.y + 12, kontrolbir.position.z);
            }
           else if (temas.gameObject.tag == "kontroliki")
            {
                cemberiki.position = new Vector3(cemberiki.position.x, cemberiki.position.y + 12, cemberiki.position.z);
                kontroliki.position = new Vector3(kontroliki.position.x, kontroliki.position.y + 12, kontroliki.position.z);
            }
            else
            {
                SceneManager.LoadScene("SampleScene");
            }

        }
        
    }
    void rastrenk()
    {
        int rast = Random.Range(0, 4);
        switch(rast)
        {
            case 0: mevcutrenk = "turkuaz"; ressam.color = turkuazrenk;break;
            case 1: mevcutrenk = "sari"; ressam.color = sarirenk; break;
            case 2: mevcutrenk = "mor"; ressam.color = morrenk; break;
            case 3: mevcutrenk = "pembe"; ressam.color = pemberenk; break;
        }
    }
}
