using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Builder Design Pattern: To separate the construction of object from its representation *****");
            
            Presentation presentation = new Presentation();
            presentation.AddSlide(new Slide("Slide 1"));
            presentation.AddSlide(new Slide("Slide 2"));
            presentation.AddSlide(new Slide("Slide 3"));

            PDFPresentationBuilder pdfPresentationBuilder = new PDFPresentationBuilder();

            presentation.export(pdfPresentationBuilder);

            MoviePresentationBuilder moviePresentationBuilder = new MoviePresentationBuilder();

            presentation.export(moviePresentationBuilder);

            Movie movie = moviePresentationBuilder.Movie;
        }
    }
}
