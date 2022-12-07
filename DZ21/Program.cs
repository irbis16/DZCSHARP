/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double[] A1 = new double[] {3,6,8};
double[] B1 = new double[] {2,1,-7};

double  ans = Math.Sqrt(Math.Pow(B1[0]-A1[0], 2) + Math.Pow(B1[1]-A1[1], 2) + Math.Pow(B1[2]-A1[2], 2));
Console.Write ($"Проверка 1: расстояние между А1 и B1 = {Math.Round(ans, 2)}");

if (Math.Round(ans, 2) == 15.84)
{
double[] A2 = new double[] {7,-5,0};
double[] B2 = new double[] {1,-1,9};

double  ans2 = Math.Sqrt(Math.Pow(B2[0]-A2[0], 2) + Math.Pow(B2[1]-A2[1], 2) + Math.Pow(B2[2]-A2[2], 2));
Console.Write ($"\n Проверка 2: расстояние между А2 и B2 = {Math.Round(ans2, 2)}");}

