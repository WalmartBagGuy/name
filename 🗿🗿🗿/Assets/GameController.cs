using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Cube Object")]
    public GameObject currentCube;
    [Header("Last Cube Object")]
    public GameObject lastCube;
    [Header("Text Object")]
    public Text text;
    [Header("Current Level")]
    public int Level;
    [Header("Boolean")]
    public bool Done;
    void Start()
    {
        NewBlock();
    }

    // Update is called once per frame
    void Update()
    {
        if (Done)
        {
            return;
        }
        var time = Mathf.Abs(Time.realTimeSinceStartup% 2f-1f);
        var pos1 =lastCube.transform.position + Vector3.up*10f;
        var pos2=pos1 + ((Level%2==0) ? Vector3.left:Vector3.forward)*120;
        if (Level % 2==0)
        {
            currentCube.transform.position = Vector3.Lerp(pos2, pos1, time)
        }
        else
        {
            currentCube.transform.position = Vector3.Lerp(pos1, pos2, time)
        }
        if (Input.GetMouseButtonDown(0))
        {
            Newblock();
        }
    }
    if(lastCube != null)
    {
        currentCube.transform.position = new Vector3(Mathf.Round(currentCube.transform.position.x)currentCube.transform.position.y,Mathf.Round(currentCube.transform.position.z))
        currentCube.transform.position = Vector3.Lerp(currentCube.transform.position, lastCube.transform.position, 0.5f) + Vector3.up * 5f:
    }
    if (currentCube.transform.localScale.x <= 0f || currentCube.transform.localScale.z <=0f)
    {
      Done = true;
      text.GameController.SetActive(true);
      text.text = "Final Score: " + Level;
      StartCoroutine(X());
      return;
    }
    lastCube = currentCube
    currentCube+ Instaniate(lastCube);
    currentCube.name + Level + "";
    currentCube.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.HSVToRGB((Level / 100f) % 1f, 1f, 1f));
    Level++
    Camera.main.transform.position = currentCube.transform.position + new Vector3(100, 100, 100);
    Camera.main.transform.LookAt(currentCube.transform.position);
    
    IEnumerator X()
    {
        yield return new WaitForSeconds(3f);
        SceneManagement.LoadScene("SampleScene");s
    }
}
