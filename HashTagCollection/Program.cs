namespace WorkingWithHashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> SpellsList = new HashSet<string>();
            SpellsList.Add("Washamin Clinmin");
            SpellsList.Add("Minimus Ratucus");
            SpellsList.Add("Waba Kadovo");
            SpellsList.Add("Shazam");
            SpellsList.Add("Avada Kadabra");



            HashSet<string> GandolfSpells = new HashSet<string>();
            GandolfSpells.Add("Forey Ramory");
            GandolfSpells.Add("Timble Shamble");
            GandolfSpells.Add("Goatus Floatus");
            GandolfSpells.Add("Glimmer Starfus");
            GandolfSpells.Add("Expresso Explodo");



            HashSet<string> olderSpells = new HashSet<string>();
            olderSpells.Add("Alakazam");
            olderSpells.Add("Bipadi Bapadi Boo");
            olderSpells.Add("Abra Kadabra");
            olderSpells.Add("Shazam");



            Console.WriteLine("Here is a list of all the Old Spells and Current Spells");
            SpellsList.UnionWith(olderSpells);
            foreach (string Spells in SpellsList)
            {
                Console.WriteLine(Spells);
            }
            Console.WriteLine();



            Console.WriteLine("Spells that are in both lists");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = SpellsList;
            bothLists.IntersectWith(olderSpells);
            foreach (string Spellis in bothLists)
            {
                Console.WriteLine(Spellis);
            }
        }
    }
}
