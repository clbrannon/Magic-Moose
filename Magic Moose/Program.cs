using Magic_Moose;



while (true) {

    Console.WriteLine("What doest thou ask of the Magic Moose?");


    string question = Console.ReadLine();


    if (question == "")
    {
        break;
    }
    else
    {
        Moose.Response();
    }

}

