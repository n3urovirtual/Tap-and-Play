using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveRandom : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    private Vector2 targetPosition;
    private Vector2 finalPosition;
    private float speed;
    private int n;
    AudioSource source;
    public AudioClip[] audioClips;
    public Sprite[] spriteArray;
    public SpriteRenderer spriteR;

    void Start()
    {
        n = 0;
        targetPosition = GetRandomPosition();
        finalPosition = new Vector2(0, 0);
        source = GetComponent<AudioSource>();
        source.clip = audioClips[Random.Range(0, audioClips.Length)];
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = spriteArray[Random.Range(0, spriteArray.Length)];
        speed = PlayerPrefs.GetFloat("Speed");
    }

    // Update is called once per frame
    void Update()
    {
            if ((Vector2)transform.position != targetPosition && n==0)
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime); 
            }
            else if ((Vector2)transform.position != targetPosition && n > 0)
            {
                transform.position = finalPosition;
            }
            else
            {
                targetPosition = GetRandomPosition();
            }
    }
    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        return new Vector2(randomX, randomY);
    }

    void OnMouseDown()
    {
        n++;
        Debug.Log("Item was pressed " + n + " times");
        
        if (n == 1)
        {
            source.Play();
            this.transform.localScale = new Vector3(2.5f, 2.5f, 0f);
            StartCoroutine(WaitForSceneLoad());
        }
    }

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
