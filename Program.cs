using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Note> notes = new List<Note>()
        {

        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Ежедневник");
            Console.WriteLine("1. Просмотреть заметки");
            Console.WriteLine("2. Добавить новую заметку");
            Console.WriteLine("3. Выйти");

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    ViewNotes(notes);
                    break;
                case ConsoleKey.D2:
                    AddNewNote(notes);
                    break;
                case ConsoleKey.D3:
                    return;
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите пункт меню, нажав соответствующую цифру или используя стрелки.");
                    break;
            }
        }
    }

    static void ViewNotes(List<Note> notes)
    {
        int selectedNoteIndex = 0;
        bool noteSelected = false; 

        while (!noteSelected)
        {
            Console.Clear();
            Console.WriteLine("Список заметок:");

            for (int i = 0; i < notes.Count; i++)
            {
                if (i == selectedNoteIndex)
                    Console.WriteLine($"> {i + 1}. {notes[i].Title}");
                else
                    Console.WriteLine($"  {i + 1}. {notes[i].Title}");
            }

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    selectedNoteIndex = Math.Max(selectedNoteIndex - 1, 0);
                    break;
                case ConsoleKey.DownArrow:
                    selectedNoteIndex = Math.Min(selectedNoteIndex + 1, notes.Count - 1);
                    break;
                case ConsoleKey.Enter:
                    if (selectedNoteIndex >= 0 && selectedNoteIndex < notes.Count)
                    {
                        Console.Clear();
                        Console.WriteLine("Подробная информация о заметке");
                        Console.WriteLine("Название: " + notes[selectedNoteIndex].Title);
                        Console.WriteLine("Описание: " + notes[selectedNoteIndex].Description);
                        Console.WriteLine("Дата: " + notes[selectedNoteIndex].Date.ToShortDateString());
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться к списку заметок...");
                        Console.ReadKey();
                    }
                    noteSelected = true;
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите номер заметки стрелками и нажмите Enter для просмотра подробной информации.");
                    break;
            }
        }
    }

    static void AddNewNote(List<Note> notes)
    {
        Console.Clear();
        Console.WriteLine("Добавление новой заметки");
        Console.WriteLine("Введите название заметки:");
        string title = Console.ReadLine();

        Console.WriteLine("Введите описание заметки:");
        string description = Console.ReadLine();

        Console.WriteLine("Введите дату заметки (гггг-мм-дд):");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Неверный формат даты. Пожалуйста, введите дату в формате гггг-мм-дд:");
        }

        Note newNote = new Note(title, description, date);
        notes.Add(newNote);
        Console.WriteLine("Заметка успешно добавлена!");
        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться к меню...");
        Console.ReadKey();
    }
}

class Note
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }

    public Note(string title, string description, DateTime date)
    {
        Title = title;
        Description = description;
        Date = date;
    }
}