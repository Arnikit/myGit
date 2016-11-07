using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Classes;
using static System.DateTime;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            var notes = new List<Note>();
            var firstnote = new Note { Id = 1, Modified = Now, Text = "My first note." };
            var secondnote = new Note { Id = 2, Modified = Now, Text = "My second note." };
            notes.Add(firstnote);
            notes.Add(secondnote);

            foreach (var note in notes)
            {
                Console.Out.WriteLine("Id: " + note.Id + ", Modified: " + note.Modified + ", Text: " + note.Text);
            }



            Console.ReadKey();
        }
    }
}
