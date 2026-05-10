// using UnityEngine;
// using UnityEngine.SceneManagement;
// using System.Collections;
// using System.Collections.Generic;

// public class LastTrigger1: MonoBehaviour
// {
//     private void OnTriggerEnter(Collider collision)
//     {
//         if (collision.gameObject.tag == "LastTrig1"){
//             SceneManager.LoadScene("CongratsScene 1");
//         }
//         else if (collision.gameObject.tag == "WrongAns1") {
//             SceneManager.LoadScene("LoseScene 1");
//         }

//         else if (collision.gameObject.tag == "LastTrig2"){
//             SceneManager.LoadScene("CongratsScene 2");
//         }
//         else if (collision.gameObject.tag == "WrongAns2") {
//             SceneManager.LoadScene("LoseScene 2");
//         }

//         else if (collision.gameObject.tag == "LastTrig3"){
//             SceneManager.LoadScene("CongratsScene 3");
//         }
//         else if (collision.gameObject.tag == "WrongAns3") {
//             SceneManager.LoadScene("LoseScene 3");
//         }

//         else if (collision.gameObject.tag == "LastTrig4"){
//             SceneManager.LoadScene("CongratsScene 4");
//         }
//         else if (collision.gameObject.tag == "WrongAns4") {
//             SceneManager.LoadScene("LoseScene 4");
//         }

//         else if (collision.gameObject.tag == "LastTrig5"){
//             SceneManager.LoadScene("CongratsScene 5");
//         }
//         else if (collision.gameObject.tag == "WrongAns5") {
//             SceneManager.LoadScene("LoseScene 5");
//         }

//         else if (collision.gameObject.tag == "LastTrig6"){
//             SceneManager.LoadScene("CongratsScene 6");
//         }
//         else if (collision.gameObject.tag == "WrongAns6") {
//             SceneManager.LoadScene("LoseScene 6");
//         }

//         else if (collision.gameObject.tag == "LastTrig7"){
//             SceneManager.LoadScene("CongratsScene 7");
//         }
//         else if (collision.gameObject.tag == "WrongAns7") {
//             SceneManager.LoadScene("LoseScene 7");
//         }

//         else if (collision.gameObject.tag == "LastTrig8"){
//             SceneManager.LoadScene("CongratsScene 8");
//         }
//         else if (collision.gameObject.tag == "WrongAns8") {
//             SceneManager.LoadScene("LoseScene 8");
//         }

//         else if (collision.gameObject.tag == "LastTrig9"){
//             SceneManager.LoadScene("CongratsScene 9");
//         }
//         else if (collision.gameObject.tag == "WrongAns9") {
//             SceneManager.LoadScene("LoseScene 9");
//         }

//         else if (collision.gameObject.tag == "LastTrig10"){
//             SceneManager.LoadScene("CongratsScene 10");
//         }
//         else if (collision.gameObject.tag == "WrongAns10") {
//             SceneManager.LoadScene("LoseScene 10");
//         }
//     }
    
// }



using UnityEngine;
using UnityEngine.SceneManagement;

public class LastTrigger1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        string tag = collision.gameObject.tag;

        if (tag.StartsWith("LastTrig"))
        {
            string number = tag.Substring(8); // длина "LastTrig"
            SceneManager.LoadScene("CongratsScene " + number);
        }
        else if (tag.StartsWith("WrongAns"))
        {
            string number = tag.Substring(8); // длина "WrongAns" тоже 8
            SceneManager.LoadScene("LoseScene " + number);
        }
    }
}