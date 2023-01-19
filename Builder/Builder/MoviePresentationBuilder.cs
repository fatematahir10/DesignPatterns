using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class MoviePresentationBuilder: PresentationBuilder
    {
        Movie _movie = new Movie();

        internal Movie Movie { get => _movie;}

        public void addSlide(string text)
        {
            _movie.addFrame(text);
        }
    }
}
