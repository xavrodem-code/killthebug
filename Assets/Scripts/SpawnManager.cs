using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabSpider;
    [SerializeField]
    private GameObject _prefabYellowInsect;
    [SerializeField]
    private GameObject _prefabWhiteInsect;
    [SerializeField]
    private GameObject _prefabRedInsect;
    [SerializeField]
    private GameObject _prefabGreyInsect;
    [SerializeField]
    private GameObject _prefabBrownInsect;
    [SerializeField]
    private GameObject _prefabBlackInsect;
    [SerializeField]
    private GameObject _bugContainer;
    private bool _stopSpawning;
    [SerializeField]
    private int _bugsLeft;
    [SerializeField]
    private int _bugsToRespawn;
    [SerializeField]
    private float _respawnTimer;
    private UIManager _uimanager;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _bugsToRespawn = _bugsLeft;
        StartCoroutine(SpawnRoutine());
        _uimanager = GameObject.Find("Canvas").GetComponent<UIManager>();    
    }


    public void BugCounter()
    {
        _bugsLeft--;
        _uimanager.UpdateBugsLeft(_bugsLeft);
    }
    void SpawnCounter()
    {
        if (_stopSpawning == false)
        {
            _bugsToRespawn--;
        }
    }


    IEnumerator SpawnRoutine()
    {
        while (_stopSpawning == false)
        {
            Vector3 posTospawn = new Vector3(Random.Range(-6.6f, 6.5f), Random.Range(-3.6f, 4.04f), 0);
            GameObject newSpider = Instantiate(_prefabSpider, posTospawn, Quaternion.identity);
            newSpider.transform.parent = _bugContainer.transform;
            SpawnCounter();
            if (_bugsToRespawn == 0)
            {
                break;
            }
            yield return new WaitForSeconds(_respawnTimer);
            Vector3 posTospawn1 = new Vector3(Random.Range(-6.6f, 6.5f), Random.Range(-3.6f, 4.04f), 0);
            GameObject newYellow = Instantiate(_prefabYellowInsect, posTospawn1, Quaternion.identity);
            newYellow.transform.parent = _bugContainer.transform;
            SpawnCounter();
            if (_bugsToRespawn == 0)
            {
                break;
            }
            yield return new WaitForSeconds(_respawnTimer);
            Vector3 posTospawn2 = new Vector3(Random.Range(-6.6f, 6.5f), Random.Range(-3.6f, 4.04f), 0);
            GameObject newWhite = Instantiate(_prefabWhiteInsect, posTospawn2, Quaternion.identity);
            newWhite.transform.parent = _bugContainer.transform;
            SpawnCounter();
            if (_bugsToRespawn == 0)
            {
                break;
            }
            yield return new WaitForSeconds(_respawnTimer);
            Vector3 posTospawn3 = new Vector3(Random.Range(-6.6f, 6.5f), Random.Range(-3.6f, 4.04f), 0);
            GameObject newRed = Instantiate(_prefabRedInsect, posTospawn3, Quaternion.identity);
            newRed.transform.parent = _bugContainer.transform;
            SpawnCounter();
            if (_bugsToRespawn == 0)
            {
                break;
            }
            yield return new WaitForSeconds(_respawnTimer);
            Vector3 posTospawn4 = new Vector3(Random.Range(-6.6f, 6.5f), Random.Range(-3.6f, 4.04f), 0);
            GameObject newGrey = Instantiate(_prefabGreyInsect, posTospawn4, Quaternion.identity);
            newGrey.transform.parent = _bugContainer.transform;
            SpawnCounter();
            if (_bugsToRespawn == 0)
            {
                break;
            }
            yield return new WaitForSeconds(_respawnTimer);
            Vector3 posTospawn5 = new Vector3(Random.Range(-6.6f, 6.5f), Random.Range(-3.6f, 4.04f), 0);
            GameObject newBrown = Instantiate(_prefabBrownInsect, posTospawn5, Quaternion.identity);
            newBrown.transform.parent = _bugContainer.transform;
            SpawnCounter();
            if (_bugsToRespawn == 0)
            {
                break;
            }
            yield return new WaitForSeconds(_respawnTimer);
            Vector3 posTospawn6 = new Vector3(Random.Range(-6.6f, 6.5f), Random.Range(-3.6f, 4.04f), 0);
            GameObject newBlack = Instantiate(_prefabBlackInsect, posTospawn6, Quaternion.identity);
            newBlack.transform.parent = _bugContainer.transform;
            SpawnCounter();
            if (_bugsToRespawn == 0)
            {
                break;
            }
            yield return new WaitForSeconds(_respawnTimer);
        }
        if (_bugsToRespawn == 0)
        {
            _stopSpawning = true;
        }
    }
}
