using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Presentation
    {
        private List<Slide> _slides = new List<Slide>();
        public void AddSlide(Slide slide)
        {
            _slides.Add(slide);
        }

        public void export(PresentationBuilder presentationBuilder)
        {
            _slides.ForEach(slide => presentationBuilder.addSlide(slide.Text));
        }
    }
}
