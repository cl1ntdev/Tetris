// List<int[,]> pane = new List<int[,]>();
// Thread.Sleep(3000);

int[,] pane = new int[20, 20]{
    //    == Y - col ==
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, // 10
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, //1
    {1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1}, // 20
    // {0,0,0,0,0,0,0,0,0,0}, //2
    // {0,0,0,0,0,0,0,0,0,0}, //3
    // {0,0,0,0,0,0,0,0,0,0}, //4
    // {0,0,0,0,0,0,0,0,0,0}, //5   V X - row ==
    // {0,0,0,0,0,0,0,0,0,0}, //6
    // {0,0,0,0,0,0,0,0,0,0}, //7
    // {0,0,0,0,0,0,0,0,0,0}, //8
    // {0,0,0,0,0,0,0,0,0,0}, //9
    // {1,1,1,1,1,1,1,1,1,1}, //10
};

int width = 20;
int height = 20;

// Console.WriteLine(pane.Length);
// Console.WriteLine(pane[0, 0]);
// pane[x,y]

void changeXpos(string direction, int xpos, int ypos)
{
    // Console.WriteLine(xpos);
    // Console.WriteLine(ypos);
    // Console.WriteLine(direction);
    // Console.WriteLine(pane[xpos, ypos]);
    // Console.WriteLine("changeXpos =>  x: " + xpos + "| y: " + ypos);
    int ycheck = 0;
    
    switch (direction)
    {
        case "LeftArrow":
            ycheck = ypos - 1;
            if (ycheck >= 0)
            {
                // Console.WriteLine("left arrow working");

                pane[xpos, ypos] = 0;
                // Console.WriteLine(pane[xpos, ypos]);
                int newYpos = ypos - 1; // update position to left
                pane[xpos, newYpos] = 1;
                ypos = newYpos;
                // Console.WriteLine(pane[xpos, ypos]);
                // Console.WriteLine(pane[xpos, newYpos]);
            }
            break;
        case "RightArrow":
            ycheck = ypos + 1;
            if (ycheck <= 9) // array size (row)
            {
                // Console.WriteLine("left arrow working");
    
                pane[xpos, ypos] = 0;
                // Console.WriteLine(pane[xpos, ypos]);
                int newYpos = ypos + 1; // update position to left
                pane[xpos, newYpos] = 1;
                ypos = newYpos;
                // Console.WriteLine(pane[xpos, ypos]);
                // Console.WriteLine(pane[xpos, newYpos]);
            }
            break;
    }
    // Console.WriteLine("changeXpos =>  x: " + xpos + "| y: " + ypos);
    
}

void fallAnimate(int xpos, int ypos){
    if(xpos<height){
        pane[xpos, ypos] = 0;
        xpos++;
        Console.WriteLine(pane[xpos, ypos]);
        pane[xpos, ypos] = 1;
    }
    
}

void game()
{
    bool isGame = true;
    string userInput = "";
    int iteration = 0;

    bool isBlockPlaced = false; // player place the block
    bool isBlockSpawn = false; // randomizer block spawning

    bool isPlayerMove = false;

    Random random = new Random();
    int randomBlockPlacementY = random.Next(0, 9);
    int blockPlaceX = 0;
    int blockPlaceY = 0;

    while (isGame)
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("block: " + randomBlockPlacementY);
        Console.WriteLine("x: " + blockPlaceX + "| y: " + blockPlaceY);

        Console.WriteLine("=========" + iteration + "==========");
        iteration++;


        // =================
        // start the game ui
        // =================

        for (int i = 0; i < height; i++)
        {
            Console.Write(i + 1 + ":");
            
            // spawn block
            if (!isBlockSpawn)
            {
                // pane [x,y] ?
                pane[0, randomBlockPlacementY] = 1;

                // track te position of the block
                blockPlaceY = randomBlockPlacementY; // fuking confusing
                blockPlaceX = 0;
                isBlockSpawn = true;
            }
            // ==============
            // fall animation
            // ==============
            // fall every iteration
            if(i % 10 == 0){ 
                
                fallAnimate(blockPlaceX, blockPlaceY);
                blockPlaceX += 1;    
            }
            
            // change position

            if (isPlayerMove)
            {
                if (userInput != "" || userInput == "LeftArrow" || userInput == "RightArrow" || userInput == "R" || userInput == "R" )
                {
                    // Console.WriteLine("changing pos");
                    // Console.WriteLine(blockPlaceY);
                    changeXpos(userInput, blockPlaceX, blockPlaceY); // change block position
                    switch(userInput){
                        case "LeftArrow":
                            blockPlaceY--;                        
                            break;
                        case "RightArrow":
                                blockPlaceY++;                        
                                break;
                        case "R" or "r":
                            isGame = false;
                            Console.Clear();
                            Console.WriteLine("GAME RELOADING");
                            Thread.Sleep(3000);
                            game();
                            break;
                        case "Q" or "q":
                            Console.Clear();
                            Console.WriteLine("Game Exit");
                            Thread.Sleep(3000);
                            isGame = false;
                            break;
                    }
                    
                
                    
                }
                
                
                isPlayerMove = false; 
            }




            // for debugging and stuff
            // Console.WriteLine(i);
            // Console.WriteLine("=========" + i + "==========");

            for (int j = 0; j < width; j++)
            {

                // Console.WriteLine(j);
                // Console.WriteLine(pane[i, j]);
                if (pane[i, j] == 1)
                {
                    Console.Write("[]");
                }
                else
                {
                    Console.Write("  ");
                }

            }

            // newline every 10 run equivalent to 1 row
            Console.WriteLine("");

        }

        // User Input
        Console.WriteLine(userInput);
        if (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            userInput = key.ToString();
            isPlayerMove = true;
        }

    }// whileloop end, ending game

}

game();
