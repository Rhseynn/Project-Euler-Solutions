
        long maxNumber = 0;        // Ən çox əməliyyat tələb edən ədəd
        long maxOperations = 0;    // Əməliyyatların maksimum sayı

        for (int i = 1; i <= 1_000_000; i++)
        {
            long number = i;
            long operations = 0;

            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number /= 2; 
                }
                else
                {
                    number = number * 3 + 1; 
                }

                operations++;
            }

            if (operations > maxOperations)
            {
                maxOperations = operations;
                maxNumber = i;
            }
        }

        Console.WriteLine($"Ən çox əməliyyat edən ədəd: {maxNumber}");
        Console.WriteLine($"Əməliyyatların sayı: {maxOperations}");
