//Andrew Solley
//Adventure In Text
//11/10/16
//Programming 2
//Period 8
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{
    
    public Text textField;
    private enum States
    {
        bedroom, bathroom, guard, courtyard, shower, fence, frontGate, touch, throws, cafeteria, run, talk, backGate, ignore, escape
    };

    private States myState;


    // Use this for initialization
    void Start()
    { 
        myState = States.bedroom;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("The current state is;" + myState);

        if (myState == States.bedroom)          { bedroom(); }
        else if (myState == States.bathroom)    { bathroom(); }
        else if (myState == States.shower)      { shower(); }
        else if (myState == States.courtyard)   { courtyard(); }
        else if (myState == States.fence)       { fence(); }
        else if (myState == States.touch)       { touch(); }
        else if (myState == States.cafeteria)   { cafeteria(); }
        else if (myState == States.throws)      { throws(); }
        else if (myState == States.frontGate)   { frontGate(); }
        else if (myState == States.run)         { run(); }
        else if (myState == States.talk)        { talk(); }
        else if (myState == States.backGate)    { backGate(); }
        else if (myState == States.ignore)      { ignore(); }
        else if (myState == States.escape)      { escape(); }
        

    }
    void bedroom()
        {textField.text = "You are in a bedroom..." +   "\n\nPress S to look at the bathroom, or M to look at courtyard";    if (Input.GetKeyDown(KeyCode.S))
        { myState = States.bathroom; }
        else if (Input.GetKeyDown(KeyCode.M))   myState = States.courtyard;}
    void bathroom()
        {textField.text = "You are in a bathroom..." +  "\n\"Press S to look at the shower, or M to go back to the bedroom.";   if (Input.GetKeyDown(KeyCode.S))
        { myState = States.shower; }
        else if (Input.GetKeyDown(KeyCode.M))    myState = States.bedroom;}
    void shower()
        {textField.text = "You are in a shower..." +    "\n\"There is nothing here, press M to go back to the bathroom.";   if (Input.GetKeyDown(KeyCode.M))
        { myState = States.bathroom; }}
    void courtyard()
        {textField.text = "You are in a coutyard..." +  "\n\"Press S to look at the fence, M to go to the cafeteria, or F to go to the front gate.";   if (Input.GetKeyDown(KeyCode.S))
        { myState = States.fence; }
        else if (Input.GetKeyDown(KeyCode.M))    myState = States.cafeteria;    else if (Input.GetKeyDown(KeyCode.F))  myState = States.frontGate;}
    void cafeteria()
        {textField.text = "You are in a cafeteria..." + "\n\"There is no food, press M to go back to the courtyard";    if (Input.GetKeyDown(KeyCode.M))
        { myState = States.courtyard; }}
    void fence()
        { textField.text = "You are at the fence..." + "\n\"Press F to touch the fence,T to throw a rock at it, or M to go back to the courtyard."; if (Input.GetKeyDown(KeyCode.F))
        { myState = States.touch; } else if (Input.GetKeyDown(KeyCode.T)) myState = States.throws; else if (Input.GetKeyDown(KeyCode.M)) myState = States.courtyard; }
    void touch()
        {textField.text = "You touch the fence..." +    "\n\"the fence is electrified, You die. Press M to restart.";   if (Input.GetKeyDown(KeyCode.M))
        { myState = States.bedroom; }}
    void throws()
        {textField.text = "You throw a rock at the fence..." +  "\n\"the fence is electrified, Press M to go back to the courtyard.";   if (Input.GetKeyDown(KeyCode.M))
        { myState = States.courtyard; }}
    void frontGate()
        {textField.text = "You approach the front gate..." +    "\n\"A guard Apporaches you. Press M to run, or S to talk to him."; if (Input.GetKeyDown(KeyCode.M))
        { myState = States.run; }   else if (Input.GetKeyDown(KeyCode.S))    myState = States.talk;}
    void run()
        {textField.text = "You ran from a guard..." +   "\n\"A sniper shoots you, You are dead. Press M to restart.";   if (Input.GetKeyDown(KeyCode.M))
        {myState = States.bedroom;}}
    void talk()
        {textField.text = "The guard says he will help you..." +"\n\"He says to go to go to the back fence to escape. Press S to go to the back gate, or M to ignore him. ";if (Input.GetKeyDown(KeyCode.M))
        {myState = States.ignore;}  if (Input.GetKeyDown(KeyCode.S))    { myState = States.backGate;}}
    void backGate()
        {textField.text = "The guard turns off the electrified fence..." +  "\n\"He opens a hole in the fence, Press M to escape, or S to go to your room";   if (Input.GetKeyDown(KeyCode.M))
        {myState = States.escape;}  if (Input.GetKeyDown(KeyCode.S))     {myState = States.bedroom;}}
   void ignore()
        {textField.text = "You ignore the guard..." +   "\n\"The other guards gather everyone, They kill you. Press M to restart "; if (Input.GetKeyDown(KeyCode.M))
        {myState = States.bedroom;}}
    void escape()
    { textField.text = "Guards shoot at you..." + "\n\"You were not hit! You successfully escaped! Press M to replay or X To close game. "; if (Input.GetKeyDown(KeyCode.M))
        { myState = States.bedroom; } }
  
}
