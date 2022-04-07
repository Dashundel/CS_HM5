//3)Написать программу масштабирования фигуры
Console.WriteLine("Введи координаты фигуры в формате (x1,y1) (x2,y2) (x3,y3) (x4,y4): " );
string coordinates = Console.ReadLine();

void getCoordinates (string s, int ind, out int x, out int y)
{
    int indX = s.IndexOf('(', ind) + 1;
    int lenX = s.IndexOf(',', ind) - indX;
    int indY = s.IndexOf(',', ind) + 1;
    int lenY = s.IndexOf(')', ind) - indY;
    x = int.Parse(s.Substring(indX, lenX) );
    y = int.Parse(s.Substring(indY, lenY) );
}

Console.WriteLine("Введи коэффициент масштабирования k: " );
int k  = int.Parse(Console.ReadLine());

int x=0, x2=0;
int y=0, y2=0;
int ind=0;
Console.WriteLine("Координаты после масштабирования: ");

for (int i = 0; i < 4; i++)
{
   getCoordinates(coordinates, ind, out x, out y); 
	x2 = x * k; 
	y2 = y * k;
	Console.WriteLine("(" + x2 + ", " + y2 +")");
    ind = coordinates.IndexOf("(",(ind + 1));
}
		
