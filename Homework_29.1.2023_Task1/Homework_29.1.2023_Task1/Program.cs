
      StarRhombus starRhombus = new StarRhombus();
      Console.Write("Enter the size of the rhombus: ");
      starRhombus.Size = int.Parse(Console.ReadLine());

      for (int i = 1; i <= starRhombus.Size; i++) {
        starRhombus.PrintRow(starRhombus.Size, i);
      }

      for (int i = starRhombus.Size - 1; i >= 1; i--) {
        starRhombus.PrintRow(starRhombus.Size, i);
      }
