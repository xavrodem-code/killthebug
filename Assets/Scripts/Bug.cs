using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    [SerializeField]
    private int _speed;
    private int _speed2;
    private Animator _bugAnimation;
    private SpawnManager _spawnManager;


    // Start is called before the first frame update
    void Start()
    {
        _bugAnimation = GetComponent<Animator>();
        _spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        StartCoroutine(Move());
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        _spawnManager.BugCounter();
    }

    private IEnumerator Move()
    {
        while (true)
        {

            yield return new WaitForSeconds(1);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
            yield return new WaitForSeconds(1);
            float moveTimer = 1f;
            while (moveTimer > 0)
            {
                gameObject.transform.Translate(Vector3.up * Time.deltaTime * _speed);
                Debug.Log("IsMoving");
                moveTimer -= Time.deltaTime;
                yield return null;
                
                if (transform.position.y >= 4.04)
                {
                    transform.position = new Vector3(transform.position.x, -3.54f, 0);
                }
                else if (transform.position.y <= -3.54)
                {
                    transform.position = new Vector3(transform.position.x, 4.04f, 0);
                }
                if (transform.position.x <= -6.66)
                {
                    transform.position = new Vector3(6.55f, transform.position.y, 0);
                }
                else if (transform.position.x >= 6.55)
                {
                    transform.position = new Vector3(-6.66f, transform.position.y, 0);
                }
                _bugAnimation.SetFloat("Speed", _speed);
            }
            _speed2 = 0;
            _bugAnimation.SetFloat("Speed", _speed2);
        }
    }
}
