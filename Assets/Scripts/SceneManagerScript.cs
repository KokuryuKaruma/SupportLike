using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void StartButtonScript()
    {
        SceneManager.LoadScene("home");
    }
    public void BaitoButtonScript()
	{
        SceneManager.LoadScene("game_home");
	}
    public void kisekaeButtonScript()
	{
        SceneManager.LoadScene("kisekae");
	}
    public void BaitoStartButton()
	{
        SceneManager.LoadScene("game");
	}
    public void ClearSceneScript()
    {
        SceneManager.LoadScene("clear");
    }
    public void shopButtonScript()
	{
        SceneManager.LoadScene("shop");
	}
    public void shop_1_Script()
	{
        SceneManager.LoadScene("character");
	}
    public void shop_2_Script()
	{
        SceneManager.LoadScene("cloth");
	}
    public void shop_3_Scrept()
	{
        SceneManager.LoadScene("haikei");
	}
    public void title_up()
	{
        SceneManager.LoadScene("Title");
	}
    public void tops()
	{
        SceneManager.LoadScene("tops");
	}
    public void accessory()
	{
        SceneManager.LoadScene("accessory");
	}
}
