using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            PersonInfo personInfo = new PersonInfo();

            Menu.MenuUI();
        }
    }
}
