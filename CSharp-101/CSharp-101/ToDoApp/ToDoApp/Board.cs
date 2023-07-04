using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Board
    {
        public static List<Card> Line = new List<Card>();
        //public static List<Card> ToDo = new List<Card>();
        //public static List<Card> InProgress = new List<Card>();
        //public static List<Card> Done = new List<Card>();

        public Board()
        {
            Line.Add(new Card("Proje", "Kurumsal Mimaride Blog Sitesi Yapılacak. ", 1, 1, "TODO"));
            Line.Add(new Card("Veri Girişi", "SQL Server ile veri girişi yapılacak. ", 2, 2, "IN PROGRESS"));
            Line.Add(new Card("Scrum", "25.04.2023 15.30 da toplantı yapılacak. ", 3, 3, "DONE"));
            Line.Add(new Card("Müşteri Hizmetleri", "Müşteriler ile iletişime geçilecek. ", 4, 4, "DONE"));
        }

    }
}
