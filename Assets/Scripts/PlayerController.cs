using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject[] Ballkuns;

    private List<GameObject> listOfBallukuns = new List<GameObject>();
    private GameObject lastBall;

    public Text ballCountText;
    private int ballsDeletd = 0;
    public bool isFinished;

    void Start()
    {
        SpawnBallkuns();
        ballCountText.text = ballsDeletd.ToString();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FirstBallkun();
        }

        if(Input.GetMouseButton(0) && listOfBallukuns.Count > 0)
        {
            Dragging();
        }

        if (Input.GetMouseButtonUp(0))
        {
            DeletBallkuns();
        }

        if (isFinished)
        {
            return;
        }
    }

    void SpawnBallkuns()
    {
        for(int i = 0; i < 40; i++)
        {
            int r = Random.Range(0, 5);
            var ball = Instantiate(Ballkuns[r]);
            ball.transform.position = new Vector2(Random.Range(-2f, 2f), Random.Range(2f, 4f));
        }
    }

    void FirstBallkun()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 0.5f);
        if(hit2D.collider != null)
        {
            if(hit2D.collider.gameObject.CompareTag("Redkun")||hit2D.collider.gameObject.CompareTag("Bluekun")||hit2D.collider.gameObject.CompareTag("Greenkun")||hit2D.collider.gameObject.CompareTag("Yellowkun")||hit2D.collider.gameObject.CompareTag("Aquakun"))
            {
                                var thisBall = hit2D.collider.gameObject;
                                listOfBallukuns.Add(thisBall);
                                Color ballColor = thisBall.GetComponent<SpriteRenderer>().color;
                                ballColor.a = 0.5f;
                                thisBall.GetComponent<SpriteRenderer>().color = ballColor;
                                lastBall = thisBall;
            }
        }
    }

    void Dragging()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 0.5f);
        if(hit2D.collider != null)
        {
            if(hit2D.collider.gameObject.tag == lastBall.tag)
            {
                var thisBall = hit2D.collider.gameObject;
                Vector2 distance = thisBall.transform.position - lastBall.transform.position;
                if(!listOfBallukuns.Contains(thisBall) && distance.magnitude <= 1.5f)
                {
                    listOfBallukuns.Add(thisBall);
                    Color ballColor = thisBall.GetComponent<SpriteRenderer>().color;
                    ballColor.a = 0.5f;
                    lastBall = thisBall;
                }
            }
        }
    }

    void DeletBallkuns()
    {
        if (listOfBallukuns.Count >= 3)
        {
            foreach (var item in listOfBallukuns)
            {
                Destroy(item);
            }

            NewBallkuns(listOfBallukuns.Count);
            ballsDeletd += listOfBallukuns.Count;
            ballCountText.text = ballsDeletd.ToString();
            //DeletBallkunsCount();
        }
        else
        {
            foreach (var item in listOfBallukuns)
            {
                Color ballColor = item.GetComponent<SpriteRenderer>().color;
                ballColor.a = 1;
                item.GetComponent<SpriteRenderer>().color = ballColor;
            }
        }

        listOfBallukuns.Clear();
    }

    /*void DeletBallkunsCount()
	{
		if (Redkun)
		{
            listOfBallukuns.Count * 10;
            ballCountText.text = ballsDeletd.ToString();
		}
	}*/

    void NewBallkuns(int ballkuns)
    {
        for(int i = 0; i < ballkuns; i++)
        {
            int r = Random.Range(0, 5);
            var ball = Instantiate(Ballkuns[r]);
            ball.transform.position = new Vector2(Random.Range(-2f, 2f), Random.Range(4, 4.5f));
        }
    }
}
