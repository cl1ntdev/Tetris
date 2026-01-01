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

bool fallAnimate(int xpos, int ypos){
    if(xpos<=height){
        // block checker if the preceeding block has something
        // Console.WriteLine("changeXpos =>  x: " + xpos + "| y: " + ypos);
        pane[xpos, ypos] = 0;
        xpos++;
        Console.WriteLine(pane[xpos, ypos]);        
        if(pane[xpos, ypos] == 1){
            xpos--;
            pane[xpos, ypos] = 1;
            return true;
        }
        
        if(xpos == height){
            Console.WriteLine("what a nice end block");
            // spawn another block
            return true;
        }else{
            pane[xpos, ypos] = 1;
        }
        
    }else{
        return false;
    }
    return false;
}
//  >> >> >> >> >> GAME LOGIC << << << << << //
// 
// 1. Game iterates to all array size, w * h = no. iterations.
// 
// 
// 
//  >> >> >> >> >> GAME LOGIC << << << << << //


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
    
    //single block spawn
    int blockPlaceX = 0;
    int blockPlaceY = 0;

    while (isGame)
    {
        Thread.Sleep(300); // tick
        Console.Clear();
        Console.WriteLine("block: " + randomBlockPlacementY);
        Console.WriteLine("x: " + blockPlaceX + "| y: " + blockPlaceY);

        Console.WriteLine("=========" + iteration + "==========");
        iteration++;

        // ==============
        // fall animation
        // ==============
        // fall every iteration
            // Console.Write("iterationssss");
            isBlockPlaced = fallAnimate(blockPlaceX, blockPlaceY);
            if(isBlockPlaced){
                Console.WriteLine("spawn another block");
            }else{
                blockPlaceX += 1;                    
            }

        // =================
        // start the game ui
        // =================

        for (int i = 0; i < height; i++)
        {
            Console.Write(i + ":");
            
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
            
            
            // GENERATE SOME STUFF BOX
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
