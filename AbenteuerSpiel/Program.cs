using AbenteuerSpiel;

EinTagFrankfurt neueSpiel = new EinTagFrankfurt();
do
{

neueSpiel.Wilkommen();
neueSpiel.Scene1();
neueSpiel.Wahl5();
       

    if (neueSpiel.wahl1)
    {
        neueSpiel.Menu1();
    }
    else if (neueSpiel.wahl2)
    {
        neueSpiel.wahl2 = false;
        neueSpiel.Bahnofsvirtel();
        neueSpiel.Wahl4();
        if (neueSpiel.wahl1)
        {
            neueSpiel.Menu1();
        }
        else if (neueSpiel.wahl2)
        {
            neueSpiel.Menu3();
        }
        else if (neueSpiel.wahl3)
        {
            neueSpiel.Menu4();
        }
        else if (neueSpiel.wahl4)
        {
            neueSpiel.Menu5();
        }

    }
    else if (neueSpiel.wahl3)
    {
        neueSpiel.Menu3();
    }
    else if (neueSpiel.wahl4)
    {
        neueSpiel.Menu4();
    }
    else if (neueSpiel.wahl5)
    {
        neueSpiel.Menu5();
    }
} while (neueSpiel.wiederSpielen);
