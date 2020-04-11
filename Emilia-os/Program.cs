/*
 * Created by SharpDevelop.
 * User: Haker
 * Date: 05.03.2020
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.IO;

using System;

namespace Emilia_os
{
	class Program
	{
		public static void Main(string[] args)
		{
		 // Utworzenie pliku i zapis danych
		 
			/*Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Clear();
			
			StreamReader plik = File.OpenText("starterpack01.txt");
			while(!plik.EndOfStream)
			{
				int kolor = int.Parse(plik.ReadLine());
				string tekst = plik.ReadLine();
				
				switch (kolor)
				{
					case 0:
						Console.ForegroundColor = ConsoleColor.Black;
						break;
					case 1:
						Console.ForegroundColor = ConsoleColor.Blue;
						break;
					case 2:
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						break;
					case 3:
						Console.ForegroundColor = ConsoleColor.Red;
						break;
					default:
						Console.ForegroundColor = ConsoleColor.Yellow;
						break;
				}
				
				Console.WriteLine(tekst);
			}
			plik.Close();
		 
           */StreamWriter plik1 = File.CreateText("notes.txt");
           plik1.WriteLine("");
           plik1.Close();
       
            // Odczyt danych z pliku
           
	          StreamReader odczyt = File.OpenText("notes.txt");
	          string linia1 = odczyt.ReadLine();
	          string linia2 = odczyt.ReadLine();
	          string linia3 = odczyt.ReadLine();
	          odczyt.Close();
         
            Console.WriteLine("{0} {1} {2}", linia1, linia2, linia3);
           
           
            // Odczyt danych pętlą
           
            

           
           

            /*plik.WriteLine("");
          
            plik.WriteLine("");
          
            plik.WriteLine("");
         
            plik.WriteLine("");
         
            plik.Close();

			*/Console.Write("Labirent.emi");
			
			Console.Write("\nKalkulator.emi");
			
			Console.Write("\nGoogle Chrome Instaler.emi");
			
			Console.Write("\nConsole (cmd).emi");
			
			Console.Write("\nKółko i krzyżyk.emi");

			Console.Write("\n\nInformacje\nAktualizacja 1.1\nPoprawka błędów i dodanie starterpack-ów");
			bool koniec1 = false;
			char klawisz1 = ' ';
			int y1 = 0;
			int x1 = 14;
			
			while(!koniec1)
			{
				Console.SetCursorPosition(x1, y1);
				Console.Write("x");
				
				
				
				if(klawisz1 == 'w')
				{
					y1--;
					Console.Clear();
					Console.SetCursorPosition(x1, y1);
					Console.Write("x");
					Console.SetCursorPosition(0, 0);
					Console.Write("Labirent.emi");
					Console.Write("\nKalkulator.emi");
					Console.Write("\nGoogle Chrome Instaler.emi");
					Console.Write("\nConsole (cmd).emi");
					Console.Write("\nKółko i krzyżyk.emi");
					Console.Write("\n\nInformacje\nAktualizacja 1.1\nPoprawka błędów i dodanie starterpack-ów");
				}
				if(klawisz1 == 's')
				{
					y1++;
					x1++;
					Console.Clear();
					Console.SetCursorPosition(x1, y1);
					Console.Write("x");
					Console.SetCursorPosition(0, 0);
					Console.Write("Labirent.emi");
					Console.Write("\nKalkulator.emi");
					Console.Write("\nGoogle Chrome Instaler.emi");
					Console.Write("\nConsole (cmd).emi");
					Console.Write("\nKółko i krzyżyk.emi");
					Console.Write("\n\nInformacje\nAktualizacja 1.1\nPoprawka błędów i dodanie starterpack-ów");
				}
				klawisz1 = Console.ReadKey().KeyChar;
				Console.SetCursorPosition(0, 0);
				if(y1 == 2)
				{
					 x1++;
					 x1++;
					 x1++;
					 x1++;
					 x1++;
					 x1++;
					 x1++;
					 x1++;
					 x1++;
					 x1++;
					 x1++;
				}
				
				if(klawisz1 == 'z')
				{
					koniec1 = true;
				}
				
			}
			
			Console.Clear();
			
			if(y1 == 4)
			{
			  char[,] plansza = new char[3,3]
              {
                { ' ', ' ', ' '},
                { ' ', ' ', ' '},
                { ' ', ' ', ' '}};
           
              char znak = 'X';
           
              int x3, y3;
              bool koniec = false;
           
	          do
	          {
	            Console.ForegroundColor = ConsoleColor.Blue;
	            Console.BackgroundColor = ConsoleColor.White;
	            Console.Clear();
	               
	            // Rysowanie planszy do grania
	               
	            Console.WriteLine();
	            Console.WriteLine("    TIC TAC TOE");
	            Console.WriteLine();
	            Console.WriteLine("     0   1   2     <- kolumny");
	                Console.WriteLine("   +---+---+---+");
	                Console.WriteLine("   |   |   |   |");
	                Console.WriteLine(" 0 | {0} | {1} | {2} |", plansza[0,0], plansza[0,1], plansza[0,2]);
	                Console.WriteLine("   |   |   |   |");
	                Console.WriteLine("   +---+---+---+");
	                Console.WriteLine("   |   |   |   |");
	                Console.WriteLine(" 1 | {0} | {1} | {2} |", plansza[1,0], plansza[1,1], plansza[1,2]);
	                Console.WriteLine("   |   |   |   |");
	                Console.WriteLine("   +---+---+---+");
	                Console.WriteLine("   |   |   |   |");
	                Console.WriteLine(" 2 | {0} | {1} | {2} |", plansza[2,0], plansza[2,1], plansza[2,2]);
	                Console.WriteLine("   |   |   |   |");
	                Console.WriteLine("   +---+---+---+");
	                Console.WriteLine(" ^ wiersze");
	               
	                // Wygrywa X
               
		                if((plansza[0,0] == 'X' && plansza[0,1] == 'X' && plansza[0,2] == 'X') ||
		                   (plansza[1,0] == 'X' && plansza[1,1] == 'X' && plansza[1,2] == 'X') ||
		                   (plansza[2,0] == 'X' && plansza[2,1] == 'X' && plansza[2,2] == 'X') ||
		                   (plansza[0,0] == 'X' && plansza[1,0] == 'X' && plansza[2,0] == 'X') ||
		                   (plansza[0,1] == 'X' && plansza[1,1] == 'X' && plansza[2,1] == 'X') ||
		                   (plansza[0,2] == 'X' && plansza[1,2] == 'X' && plansza[2,2] == 'X') ||
		                   (plansza[0,0] == 'X' && plansza[1,1] == 'X' && plansza[2,2] == 'X') ||
		                   (plansza[2,0] == 'X' && plansza[1,1] == 'X' && plansza[0,2] == 'X'))
		                {
		                    Console.WriteLine();
		                    Console.ForegroundColor = ConsoleColor.Magenta;
		                    Console.WriteLine("   Wygrywa X");
		                    Console.ReadKey();
		                    koniec = true;
		                }
		               
		                // Wygrywa O
		               
		                if((plansza[0,0] == 'O' && plansza[0,1] == 'O' && plansza[0,2] == 'O') ||
		                   (plansza[1,0] == 'O' && plansza[1,1] == 'O' && plansza[1,2] == 'O') ||
		                   (plansza[2,0] == 'O' && plansza[2,1] == 'O' && plansza[2,2] == 'O') ||
		                   (plansza[0,0] == 'O' && plansza[1,0] == 'O' && plansza[2,0] == 'O') ||
		                   (plansza[0,1] == 'O' && plansza[1,1] == 'O' && plansza[2,1] == 'O') ||
		                   (plansza[0,2] == 'O' && plansza[1,2] == 'O' && plansza[2,2] == 'O') ||
		                   (plansza[0,0] == 'O' && plansza[1,1] == 'O' && plansza[2,2] == 'O') ||
		                   (plansza[2,0] == 'O' && plansza[1,1] == 'O' && plansza[0,2] == 'O'))
		                {
		                    Console.WriteLine();
		                    Console.ForegroundColor = ConsoleColor.Magenta;
		                    Console.WriteLine("   Wygrywa O");
		                    Console.ReadKey();
		                    koniec = true;
		                }
		               
		                if(koniec == false)
		                {
		                    do
		                    {
		                        Console.SetCursorPosition(0, 19);
		                        Console.ForegroundColor = ConsoleColor.Blue;
		                        Console.WriteLine("  Gracz {0}", znak);
		                       
		                        Console.Write("  Wybierz kolumnę (0-2): ");
		                        Console.ForegroundColor = ConsoleColor.Red;
		                        x3 = int.Parse(Console.ReadLine());
		                       
		                        Console.ForegroundColor = ConsoleColor.Blue;
		                        Console.Write("  Wybierz wiersz (0-2): ");
		                        y3 = int.Parse(Console.ReadLine());
		                       
		                        Console.ForegroundColor = ConsoleColor.Blue;
		                        if(x3 < 0 || x3 > 2 || y3 < 0 || y3 > 2)
		                            return;
		                    }
		                    while(plansza[y3, x3] != ' ');
		                   
		                    plansza[y3, x3] = znak;
		                    if (znak == 'X')
		                        znak = 'O';
		                    else
		                        znak = 'X';
		                }
		            }
		            while(!koniec);
		           
		            Console.ReadKey(true);
			}
			
			if(y1 == 1)
			{
				Console.WriteLine("Wprowadź liczbę1 :");
				double liczba1 = double.Parse(Console.ReadLine());
			
				Console.WriteLine("Wprowadź liczbę2 :");
				double liczba2 = double.Parse(Console.ReadLine());
			
				double suma = liczba1 + liczba2;
				double roznica = liczba1 - liczba2;
				double iloczyn = liczba1 * liczba2;
				double iloraz = liczba1 / liczba2;
			
				Console.WriteLine("suma: {0}", suma);
				Console.WriteLine("różnica: {0}", roznica);
				Console.WriteLine("iloczyn: {0}", iloczyn);
				Console.WriteLine("iloraz: {0}", iloraz);
				Console.ReadKey();
			}
			
			if(y1 == 0)
			{
				char[,] plansza = new char[10,10]
			{
				{ '#', '#','#', '#', '#', '#', '#', '#', '#',  '#' },
				{ '#', ' ', '#', ' ', '#', '#', '#', '#', ' ', '#' },
				{ '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
				{ '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
				{ '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#' },
				{ '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
				{ '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
				{ '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#' },
				{ '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#' },
				{ '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#' }
			};
			
			// Koordynaty naszej postaci w labirencie
			
			int x = 1;
			int y = 1;
			
			Console.CursorVisible = false; // Ukrycie kursora
			
			// Wyświetlenie ekranu startowego
			
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Clear();
			
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("+					    +");
			Console.WriteLine("+       # # Labirent Emilia-os # #          +");
			Console.WriteLine("+					    +");
			Console.WriteLine("+       Onajdź wyjście z labirentu          +");
			Console.WriteLine("+					    +");
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
			
			
			
			Console.ReadKey();
			
			Console.Clear();
			
			char klawisz = ' ';
			bool koniec = false;
			
			while(!koniec)
			{
				Console.ForegroundColor = ConsoleColor.White;
				for(int j = 0; j < 10; j++)
				{
					for(int i = 0; i < 10; i++)
					{
						Console.SetCursorPosition(i, j);
						Console.Write(plansza[j, i]);
					}
				}
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.SetCursorPosition(x, y);
				Console.Write("@");

				Console.SetCursorPosition(0, 0);
				klawisz = Console.ReadKey().KeyChar;
				
				int px = x;
				int py = y;
				
				if(klawisz == 'w')
				{
					y--;
				}
				if(klawisz == 's')
				{
					y++;
				}
				if(klawisz == 'a')
				{
					x--;
				}
				if(klawisz == 'd')
				{
					x++;
				}
				
				if(plansza[y, x] != ' ')
				{
					x = px;
					y = py;
				}
				
				if(x == 8 && y == 9)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();
					Console.SetCursorPosition(0, 0);
					Console.WriteLine("MISJA UKOŃCZONA");
					koniec = true;
				}
			}
			
			}
				char klawisz2 = ' ';
				int y2 = 0;
				int x2 = 14;
				bool koniec2 = false;
			
			if(y1 == 3)
			{
				string command;
				Console.Clear();
				Console.SetCursorPosition(0, 0);
				Console.WriteLine(">>>");
				Console.SetCursorPosition(3, 0);
				command = Console.ReadLine();
				if(command == "X6829")
				{
					Console.ReadKey();
				
					Console.Clear();
			
					Console.Write("Labirent.emi");
				
					Console.Write("\nKalkulator.emi");
				
					Console.Write("\nGoogle Chrome.emi");
	
				
					while(!koniec2)
					{
						Console.SetCursorPosition(x2, y2);
						Console.Write("x");
					
					
					
						if(klawisz2 == 'w')
						{
							y2--;
							Console.Clear();
							Console.SetCursorPosition(x2, y2);
							Console.Write("x");
							Console.SetCursorPosition(0, 0);
							Console.Write("Labirent.emi");
							Console.Write("\nKalkulator.emi");
							Console.Write("\nGoogle Chrome.emi");
						}
						if(klawisz2 == 's')
						{
							y2++;
							x2++;
							Console.Clear();
							Console.SetCursorPosition(x2, y2);
							Console.Write("x");
							Console.SetCursorPosition(0, 0);
							Console.Write("Labirent.emi");
							Console.Write("\nKalkulator.emi");
							Console.Write("\nGoogle Chrome.emi");
						}
						klawisz2 = Console.ReadKey().KeyChar;
						Console.SetCursorPosition(0, 0);
						if(klawisz2 == 'z')
							{
								koniec2 = true;
							}
					
				}
			}
				
			if(y1 == 2)
			{
				Console.SetCursorPosition(0, 0);
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				Console.WriteLine("+					    +");
				Console.WriteLine("+              Instalator                   +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+     Witamy w instalatorze Google Chrome   +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+					    +");
				Console.Write("+	xx				    +");
				Console.WriteLine("\n+					    +");
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				Console.SetCursorPosition(10, 7);
				Console.Write("xx");
				Console.SetCursorPosition(12, 7);
				Console.Write("xx");
				Console.SetCursorPosition(14, 7);
				Console.Write("xx");
				Console.SetCursorPosition(16, 7);
				Console.Write("xx");
				Console.SetCursorPosition(18, 7);
				Console.Write("xx");
				Console.SetCursorPosition(20, 7);
				Console.Write("xx");
				Console.SetCursorPosition(22, 7);
				Console.Write("xx");
				Console.SetCursorPosition(24, 7);
				Console.Write("xx");
				Console.SetCursorPosition(26, 7);
				Console.Write("xx");
				Console.SetCursorPosition(28, 7);
				Console.Write("xx");
				Console.SetCursorPosition(30, 7);
				Console.Write("xx 100%");
				Console.SetCursorPosition(4, 8);
				Console.Write("Udało się zainstalować Google Chrome");
				
				Console.ReadKey();
				
				Console.Clear();
			
				Console.Write("Labirent.emi");
			
				Console.Write("\nKalkulator.emi");
			
				Console.Write("\nGoogle Chrome.emi");

			
				while(!koniec2)
				{
					Console.SetCursorPosition(x2, y2);
					Console.Write("x");
				
				
				
					if(klawisz2 == 'w')
					{
						y2--;
						Console.Clear();
						Console.SetCursorPosition(x2, y2);
						Console.Write("x");
						Console.SetCursorPosition(0, 0);
						Console.Write("Labirent.emi");
						Console.Write("\nKalkulator.emi");
						Console.Write("\nGoogle Chrome.emi");
					}
					if(klawisz2 == 's')
					{
						y2++;
						x2++;
						Console.Clear();
						Console.SetCursorPosition(x2, y2);
						Console.Write("x");
						Console.SetCursorPosition(0, 0);
						Console.Write("Labirent.emi");
						Console.Write("\nKalkulator.emi");
						Console.Write("\nGoogle Chrome.emi");
					}
					klawisz2 = Console.ReadKey().KeyChar;
					Console.SetCursorPosition(0, 0);
					if(klawisz2 == 'z')
						{
							koniec2 = true;
						}
					
				}
			}
			
			
			
			Console.Clear();
			
			if(y2 == 1)
			{
				Console.WriteLine("Wprowadź liczbę1 :");
				double liczba1 = double.Parse(Console.ReadLine());
			
				Console.WriteLine("Wprowadź liczbę2 :");
				double liczba2 = double.Parse(Console.ReadLine());
			
				double suma = liczba1 + liczba2;
				double roznica = liczba1 - liczba2;
				double iloczyn = liczba1 * liczba2;
				double iloraz = liczba1 / liczba2;
			
				Console.WriteLine("suma: {0}", suma);
				Console.WriteLine("różnica: {0}", roznica);
				Console.WriteLine("iloczyn: {0}", iloczyn);
				Console.WriteLine("iloraz: {0}", iloraz);
			}
			
			if(y2 == 0)
			{
				char[,] plansza = new char[10,10]
			{
				{ '#', '#','#', '#', '#', '#', '#', '#', '#',  '#' },
				{ '#', ' ', '#', ' ', '#', '#', '#', '#', ' ', '#' },
				{ '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
				{ '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
				{ '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#' },
				{ '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
				{ '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
				{ '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#' },
				{ '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#' },
				{ '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#' }
			};
			
			// Koordynaty naszej postaci w labirencie
			
			int x = 1;
			int y = 1;
			
			Console.CursorVisible = false; // Ukrycie kursora
			
			// Wyświetlenie ekranu startowego
			
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Clear();
			
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("+					    +");
			Console.WriteLine("+       # # Labirent Emilia-os # #          +");
			Console.WriteLine("+					    +");
			Console.WriteLine("+       Onajdź wyjście z labirentu          +");
			Console.WriteLine("+					    +");
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
			
			
			
			Console.ReadKey();
			
			Console.Clear();
			
			char klawisz = ' ';
			bool koniec = false;
			
			while(!koniec)
			{
				Console.ForegroundColor = ConsoleColor.White;
				for(int j = 0; j < 10; j++)
				{
					for(int i = 0; i < 10; i++)
					{
						Console.SetCursorPosition(i, j);
						Console.Write(plansza[j, i]);
					}
				}
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.SetCursorPosition(x, y);
				Console.Write("@");

				Console.SetCursorPosition(0, 0);
				klawisz = Console.ReadKey().KeyChar;
				
				int px = x;
				int py = y;
				
				if(klawisz == 'w')
				{
					y--;
				}
				if(klawisz == 's')
				{
					y++;
				}
				if(klawisz == 'a')
				{
					x--;
				}
				if(klawisz == 'd')
				{
					x++;
				}
				
				if(plansza[y, x] != ' ')
				{
					x = px;
					y = py;
				}
				
				if(x == 8 && y == 9)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();
					Console.SetCursorPosition(0, 0);
					Console.WriteLine("MISJA UKOŃCZONA");
					koniec = true;
				}
			}
			
			}
			
			if(y2 == 2)
			{
				Console.SetCursorPosition(0, 0);
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				Console.WriteLine("+ Google Chrome			            +");
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				Console.WriteLine("+					    +");
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				Console.WriteLine("+					    +");
				Console.WriteLine("+   					    +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				
				
				
				string adres;
				Console.SetCursorPosition(0, 0);
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				Console.WriteLine("+ Google Chrome			            +");
				Console.SetCursorPosition(1, 3);
				adres = Console.ReadLine();
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				Console.WriteLine("+					    +");
				Console.WriteLine("+   					    +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+					    +");
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
				
				if(adres == "mario")
				{
					Console.SetCursorPosition(5, 5);
					Console.WriteLine("Emilia-os start page");
				}
			}
			if(y2 == 3)
			{
				
			}
			
			Console.ReadKey(true);
		}
	}
	}}