using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}

// La clase Book representa un libro, pero está tratando de hacer más de una cosa.
// La responsabilidad principal de la clase Book debería ser representar la información básica de un libro, como el título, el autor y el código. 

Parte 2:

public class Libro
{
    public string Título { get; }
    public string Autor { get; }
    public string Código { get; }

    public Libro(string título, string autor, string código)
    {
        Título = título;
        Autor = autor;
        Código = código;
    }
}

public class ÍtemDeBiblioteca
{
    public string SectorDeBiblioteca { get; set; }
    public string EstanteDeBiblioteca { get; set; }

    public void ColocarEnEstante(string sector, string estante)
    {
        SectorDeBiblioteca = sector;
        EstanteDeBiblioteca = estante;
    }
}
