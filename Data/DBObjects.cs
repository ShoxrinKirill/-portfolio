using System.Linq;
using System.Collections.Generic;
using _portfolio.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace _portfolio.Data
{
    public class DBObjects
    {
        public static void Initial(DatabaseContext context)
        {
            if(!context.Example.Any())
            {
                context.AddRange(
                    new Example {
                        nameExample = "Пример первый", 
                        description = "Some quick example text to build on the card title and make up the bulk of the card's content.Some quick example text to build on the card title and make up the bulk of the card's content.", 
                        img = "/img/Example_1.png"
                    },
                    new Example {
                        nameExample = "Пример второй", 
                        description = "Some quick example text to build on the card title and make up the bulk of the card's content.Some quick example text to build on the card title and make up the bulk of the card's content.", 
                        img = "/img/Example_1.png"
                    },
                    new Example {
                        nameExample = "Пример третий", 
                        description = "Some quick example text to build on the card title and make up the bulk of the card's content.Some quick example text to build on the card title and make up the bulk of the card's content.", 
                        img = "/img/Example_1.png"
                    },
                    new Example {
                        nameExample = "Пример четвертый", 
                        description = "Some quick example text to build on the card title and make up the bulk of the card's content.Some quick example text to build on the card title and make up the bulk of the card's content.", 
                        img = "/img/Example_1.png"
                    }
                );
            }

            context.SaveChanges();
        }
    }
}