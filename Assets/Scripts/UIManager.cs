using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private int _bugnum;
    [SerializeField]
    private Text _bugsLefttext;
    [SerializeField]
    private Text _greatJobtext;
    [SerializeField]
    private Text _nextLeveltext;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _bugsLefttext.text = "Bugs: " + _bugnum;
        _greatJobtext.gameObject.SetActive(false);
        _nextLeveltext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void UpdateBugsLeft(int bugskilled)
    {
        _bugsLefttext.text = "Bugs: " + bugskilled.ToString();
        if (bugskilled == 0)
        {
            GreatJobSequence();
            StartCoroutine(PressForNextLevel());
        }
    }


    public void GreatJobSequence()
    {
        _greatJobtext.gameObject.SetActive(true);
        _nextLeveltext.gameObject.SetActive(true);
        StartCoroutine(GreatJobFlickerRoutine());
    }

    IEnumerator GreatJobFlickerRoutine()
    {
        while (true)
        {
            _greatJobtext.text = "GREAT JOB!";
            yield return new WaitForSeconds(0.5f);
            _greatJobtext.text = "";
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator PressForNextLevel()
    {
        if (Input.GetMouseButtonDown(0))
        {
            yield return new WaitForSeconds(5f);
            _gameManager.NextLevel();
        }
    }
}
