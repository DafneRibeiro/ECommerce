using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "The Hitchhiker's Guide to the Galaxy",
                Description = "The broad narrative of Hitchhiker follows the misadventures of the last surviving man, Arthur Dent, following the demolition of the Earth by a Vogon constructor fleet to make way for a hyperspace bypass. Dent is rescued from Earth's destruction by Ford Prefect—a human-like alien writer for the eccentric, electronic travel guide The Hitchhiker's Guide to the Galaxy—by hitchhiking onto a passing Vogon spacecraft. Following his rescue, Dent explores the galaxy with Prefect and encounters Trillian, another human who had been taken from Earth (before its destruction) by the self-centred President of the Galaxy Zaphod Beeblebrox and the depressed Marvin the Paranoid Android. Certain narrative details were changed among the various adaptations.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "The Book of Lies (Crowley)",
                Description = "The Book of Lies is a book written by English occultist and teacher Aleister Crowley (using the pen name of Frater Perdurabo) and first published in 1912 or 1913 . As Crowley describes it: This book deals with many matters on all planes of the very highest importance. It is an official publication for Babes of the Abyss, but is recommended even to beginners as highly suggestive.The book consists of 91 chapters, each of which consists of one page of text. The chapters include a question mark, an exclamation mark, poems, rituals, instructions, and obscure allusions and cryptograms. The subject of each chapter is generally determined by its number and its corresponding Qabalistic meaning. Around 1921, Crowley wrote a short commentary about each chapter, assisting the reader in the Qabalistic interpretation.Several chapters and a photograph in the book reference Leila Waddell, whom Crowley called Laylah, and who, as Crowley's influential Scarlet Woman, acted as his muse during the writing process of this volume.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/09/TheBookofLies-AleisterCrowley.jpg",
                Price = 8.99m
            },
            new Product
            {
                Id = 3,
                Title = "The Mists of Avalon",
                Description = "The Mists of Avalon is a 1983 historical fantasy novel by American writer Marion Zimmer Bradley, in which the author relates the Arthurian legends from the perspective of the female characters. The book follows the trajectory of Morgaine (Morgan le Fay), a priestess fighting to save her Celtic religion in a country where Christianity threatens to destroy the pagan way of life.[1] The epic is focused on the lives of Morgaine, Gwenhwyfar (Guinevere), Viviane, Morgause, Igraine and other women of the Arthurian legend. The Mists of Avalon is in stark contrast to most other retellings of the Arthurian tales, which consistently cast Morgan le Fay as a distant, one-dimensional evil sorceress, with little or no explanation given for her antagonism to the Round Table. In this case, Morgaine is presented as a woman with unique gifts and responsibilities at a time of enormous political and spiritual upheaval who is called upon to defend her indigenous heritage against impossible odds.The story is told in four large parts: Book One: Mistress of Magic, Book Two: The High Queen, Book Three: The King Stag, and Book Four: The Prisoner in the Oak. The novel was a best-seller upon its publication and remains popular to this day. Bradley and Diana L. Paxson later expanded the book into the Avalon series.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/37/Mists_of_Avalon-1st_ed.jpg",
                Price = 10.99m
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(Products);
        }
    }
}
