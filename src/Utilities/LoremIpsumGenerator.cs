using System.Collections.Generic;
using System.Text;

namespace devutils
{
    internal class LoremIpsumGenerator
    {
        static readonly List<string> loremIpsumWords;// = new List<string>();

        static LoremIpsumGenerator()
        {
            #region Add words

            loremIpsumWords = new List<string> { "A", "Ab", "Ac", "Accumsan", "Accusantium", "Ad", "Adipisci",
            "Adipiscing", "Aenean", "Aliqua", "Aliquam", "Aliquet", "Aliquid", "Aliquip", "Amet", "Anim",
            "Ante", "Aperiam", "Aptent", "Architecto", "Arcu", "Aspernatur", "At", "Auctor", "Augue", "Aut",
            "Aute", "Autem", "Beatae", "Blandit", "Cillum", "Class", "Commodi", "Commodo", "Condimentum",
            "Congue", "Consectetuer", "Consectetur", "Consequat", "Consequatur", "Consequuntur", "Conubia",
            "Convallis", "Corporis", "Cras", "Cubilia", "Culpa", "Cupidatat", "Curabitur", "Curae;", "Cursus",
            "Dapibus", "Deserunt", "Diam", "Dicta", "Dignissim", "Do", "Dolor", "Dolore", "Dolorem",
            "Doloremque", "Dolores", "Donec", "Dui", "Duis", "Ea", "Eaque", "Egestas", "Eget", "Eius",
            "Eiusmod", "Elementum", "Elit", "Enim", "Eos", "Error", "Esse", "Est", "Et", "Etiam", "Eu",
            "Euismod", "Eum", "Ex", "Excepteur", "Exercitation", "Exercitationem", "Explicabo", "Facilisi",
            "Facilisis", "Faucibus", "Felis", "Fermentum", "Feugiat", "Fringilla", "Fugiat", "Fugit", "Fusce",
            "Himenaeos", "Iaculis", "Id", "Illo", "Illum", "Imperdiet", "In", "Inceptos", "Incididunt",
            "Incidunt", "Integer", "Interdum", "Inventore", "Ipsa", "Ipsam", "Ipsum", "Irure", "Iste", "Iure",
            "Justo", "Labore", "Laboriosam", "Laboris", "Laborum", "Lacinia", "Lacus", "Laoreet", "Laudantium",
            "Lectus", "Libero", "Ligula", "Litora", "Lorem", "Luctus", "Maecenas", "Magna", "Magnam", "Magni",
            "Malesuada", "Massa", "Mattis", "Mauris", "Metus", "Mi", "Minim", "Minima", "Modi", "Molestiae",
            "Molestie", "Mollis", "Mollit", "Morbi", "Nam", "Natus", "Nec", "Nemo", "Neque", "Nesciunt", "Nibh",
            "Nihil", "Nisi", "Nisl", "Non", "Nostra", "Nostrud", "Nostrum", "Nulla", "Nullam", "Numquam",
            "Nunc", "Occaecat", "Odio", "Odit", "Officia", "Omnis", "Orci", "Pariatur", "Pede", "Pellentesque",
            "Per", "Perspiciatis", "Pharetra", "Porro", "Porta", "Porttitor", "Posuere", "Potenti", "Praesent",
            "Pretium", "Primis", "Proident", "Proin", "Pulvinar", "Purus", "Quae", "Quaerat", "Quam", "Quasi",
            "Qui", "Quia", "Quis", "Quisquam", "Quisque", "Quo", "Ratione", "Rem", "Reprehenderit", "Risus",
            "Sagittis", "Sapien", "Scelerisque", "Sed", "Sem", "Semper", "Sequi", "Si", "Sint", "Sit",
            "Sociosqu", "Sodales", "Sollicitudin", "Sunt", "Suscipit", "Suspendisse", "Taciti", "Tellus",
            "Tempor", "Tempora", "Tincidunt", "Torquent", "Tortor", "Totam", "Tristique", "Turpis", "Ullam",
            "Ullamco", "Ullamcorper", "Ultrices", "Ultricies", "Unde", "Urna", "Ut", "Vel", "Velit",
            "Venenatis", "Veniam", "Veritatis", "Vestibulum", "Vitae", "Vivamus", "Viverra", "Voluptas",
            "Voluptate", "Voluptatem", "Volutpat" };

            #endregion Add words
        }

        public static string Get()
        {
            return Get(1);
        }

        public static string Get(int wordCount)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < wordCount; i++)
            {
                var idx = PseudoRandomNumberGenerator.Next(0, (loremIpsumWords.Count - 1));
                builder.Append(" ");
                builder.Append(loremIpsumWords[idx]);
            }

            return builder.ToString();
        }
    }
}
