using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnitCreatorController : MonoBehaviour {

    public GameObject Top;
    public GameObject Bot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeBot(GameObject Prefab)
    {
        GameObject BotPart = Instantiate(Prefab);
        BotPart.transform.position = Bot.transform.position;
        BotPart.transform.rotation = Bot.transform.rotation;
        BotPart.transform.parent = Bot.transform.parent;
        Destroy(Bot);
        Bot = BotPart;
    }

    public void ChangeTop(GameObject Prefab)
    {
        GameObject TopPart = Instantiate(Prefab);
        TopPart.transform.position = Top.transform.position;
        TopPart.transform.rotation = Top.transform.rotation;
        TopPart.transform.parent = Top.transform.parent;
        Destroy(Top);
        Top = TopPart;
    }

    public void Mision1Start(GameObject Unit)
    {
        PrefabUtility.CreatePrefab("Assets/Resources/Units/" + Unit.name + ".prefab", Unit);
        SceneManager.LoadScene("Mision1");
    }
}
