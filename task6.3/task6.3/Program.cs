string[,] symbol = { { null,null,"*",null,null },
                     { null,null,"*",null,null },
                     { "*","*","*","*","*" },
                     { null,null,"*",null,null },
                     { null,null,"*",null,null },};

for(var i = 0; i < symbol.GetLength(0); i++)
{
    for(var j = 0; j < symbol.GetLength(1); j++)
    {
        Console.Write(symbol[i,j]+ "\t");
    }
    Console.WriteLine();
}