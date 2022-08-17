//Написать программу для разворота массива

// var a = new[]{1,2,3,4,5,6,7};
// for(var i = 0; i < a.Length/2; i++)
// {
//     (a[i], a[a.Length-(i+1)]) = (a[a.Length-(i+1)], a[i]); //обмен элементов
// }
 
// Console.WriteLine(string.Join(" ", a));

var a = new[]{1,2,3,4,5,6,7};
Array.Reverse(a);
Console.WriteLine(string.Join(" ", a));