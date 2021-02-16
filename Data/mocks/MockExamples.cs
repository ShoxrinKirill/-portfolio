using System.Collections.Generic;
using _portfolio.Data.interfaces;
using _portfolio.Data.Models;

namespace _portfolio.Data.mocks
{
    public class MockExamples : IExamples
    {
        public IEnumerable<Example> AllExamples {
            get {
                return new List<Example> {
                    new Example{nameExample = "Пример первый", description = "Some quick example text to build on the card title and make up the bulk of the card's content.Some quick example text to build on the card title and make up the bulk of the card's content.", img = "/img/Example_1.png"},
                    new Example{nameExample = "Пример второй", description = "Some quick example text to build on the card title and make up the bulk of the card's content.Some quick example text to build on the card title and make up the bulk of the card's content.", img = "/img/Example_1.png"},
                    new Example{nameExample = "Пример третий", description = "Some quick example text to build on the card title and make up the bulk of the card's content.Some quick example text to build on the card title and make up the bulk of the card's content.", img = "/img/Example_1.png"},
                    new Example{nameExample = "Пример четвертый", description = "Some quick example text to build on the card title and make up the bulk of the card's content.Some quick example text to build on the card title and make up the bulk of the card's content.", img = "/img/Example_1.png"}
                };
            }
        }
    }
}