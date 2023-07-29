Console.Write("Введите номер дня недели "); 
                int num = int.Parse (Console.ReadLine()); 
                if (num >= 1 & num <= 5) //& = и
                { 
                    Console.Write("Это не выходной"); 
                } 
 
                else if (num >= 6 & num <= 7) 
                { 
                    Console.Write(" Это выходной"); 
                } 
                else Console.Write(" Не существует такого дня недели");