using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro1,
        intro2,
        delen,
        deelnee,
        deelja,
        leukgesprek,
        deeltadres,
        nacht,
        checksloten


    }
    private States currentState = States.start;




    // Start is called before the first frame update
    void Start()
    {

        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Write("Welkom bij HorrorNite");
        Write("Dit is gebaseerd op een waargebeurd verhaal");
        Write("Typ start om te kunnen beginnen");


    }

    void Write(string line)
    {
        Terminal.WriteLine(line);
    }



    void OnUserInput(string input)

    {
        if (currentState == States.start)
        {
            if (input == "start")
            {
                currentState = States.intro1;
                StartIntro();
            }

            else if (input == "1337")
            {
                Write("Jij bent Leet!");
            }
            else
            {
                Write("Dat commando bestaat niet");
            }
        



        }

        void StartIntro()
        {

            Terminal.ClearScreen();
            Write("Het was een koude donkere nacht");
            Write("Een heerlijke nacht om lekker Fortnite te doen!");
            Write("Typ verder om door te gaan");


        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
